using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macierze
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int size = (int)numSize.Value;
            int threads = (int)numThreads.Value;

            button1.Enabled = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("Trwają pomiary porównawcze (po 10 prób)...");

            var results = await Task.Run(() =>
            {
                var logic = new Matrix();
                var A = logic.Generate(size);
                var B = logic.Generate(size);

                double seqTime = logic.Multiply(size, 1).seq;
                double parallelTime = logic.Multiply(size, threads).par;
                double manualThreadTime = logic.MultiplyThreads(size, threads).par;

                return new { Seq = seqTime, Par = parallelTime, Thr = manualThreadTime };
            });

            double speedupPar = (double)results.Seq / results.Par;
            double speedupThr = (double)results.Seq / results.Thr;

            listBox1.Items.Add($"--- WYNIKI (średnia z 10 prób) ---");
            listBox1.Items.Add($"Rozmiar macierzy: {size}x{size}");
            listBox1.Items.Add($"1. Sekwencyjnie:      {results.Seq:F6} ms");
            listBox1.Items.Add($"2. Parallel.For ({threads} wątki): {results.Par:F6} ms");
            listBox1.Items.Add($"   Przyspieszenie:     {speedupPar:F2}x");
            listBox1.Items.Add($"3. Klasa Thread ({threads} wąki): {results.Thr:F6} ms");
            listBox1.Items.Add($"   Przyspieszenie:     {speedupThr:F2}x");

            button1.Enabled = true;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
