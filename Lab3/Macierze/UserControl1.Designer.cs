namespace Macierze
{
    partial class UserControl1
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            numSize = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numThreads = new NumericUpDown();
            button1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThreads).BeginInit();
            SuspendLayout();
            // 
            // numSize
            // 
            numSize.Location = new Point(48, 102);
            numSize.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(120, 23);
            numSize.TabIndex = 0;
            numSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 84);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Rozmiar macierzy";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 176);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Ilość wątków";
            // 
            // numThreads
            // 
            numThreads.Location = new Point(48, 194);
            numThreads.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numThreads.Name = "numThreads";
            numThreads.Size = new Size(120, 23);
            numThreads.TabIndex = 3;
            numThreads.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(48, 261);
            button1.Name = "button1";
            button1.Size = new Size(120, 37);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(270, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(869, 619);
            listBox1.TabIndex = 8;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(numThreads);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numSize);
            Name = "UserControl1";
            Size = new Size(1158, 669);
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThreads).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSize;
        private Label label1;
        private Label label2;
        private NumericUpDown numThreads;
        private Button button1;
        private ListBox listBox1;
    }
}
