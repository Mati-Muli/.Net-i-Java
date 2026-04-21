using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macierze
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        private Bitmap oImage;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    oImage = new Bitmap(openFileDialog.FileName);
                }
                pictureBox1.Image = oImage;
            }
        }

        


        private async void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Images proc = new Images();
            Bitmap copy1 = new Bitmap(oImage);
            Bitmap copy2 = new Bitmap(oImage);
            Bitmap copy3 = new Bitmap(oImage);
            Bitmap copy4 = new Bitmap(oImage);
            await Task.Run(() =>
            {
                Parallel.Invoke(
                    () =>
                    {
                        Bitmap res = proc.Negative(copy1);
                        pictureBox2.Invoke(new Action(() => pictureBox2.Image = res));
                    },
                    () =>
                    {
                        Bitmap res = proc.Gray(copy2);
                        pictureBox3.Invoke(new Action(() => pictureBox3.Image = res));
                    },
                    () =>
                    {
                        Bitmap res = proc.Thresholding(copy3);
                        pictureBox4.Invoke(new Action(() => pictureBox4.Image = res));
                    },
                    () =>
                    {
                        Bitmap res = proc.Tint(copy4);
                        pictureBox5.Invoke(new Action(() => pictureBox5.Image = res));
                    }
                );
            });
            button2.Enabled = true;
        }
    }
}

