using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macierze
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int size = (int)numSize.Value;
            int threads = (int)numThreads.Value;

            button1.Enabled = false;
            listBox1.Items.Add("Trwają obliczenia (10 prób)...");

            var results = await Task.Run(() =>
            {
                var logic = new Matrix();
                return logic.Multiply(size, threads);
            });

            double speedup = (double)results.seq / results.par;


            listBox1.Items.Add($"--- WYNIKI (średnia z 10 prób) ---");
            listBox1.Items.Add($"Rozmiar macierzy: {size}x{size}");
            listBox1.Items.Add($"Czas sekwencyjny: {results.seq} ms");
            listBox1.Items.Add($"Czas równoległy ({threads} wątki): {results.par} ms");
            listBox1.Items.Add($"Uzyskane przyśpieszenie: {speedup:F2}x");

            listBox1.Items.Add("Gotowe.");
            button1.Enabled = true;
        }
    }
}
