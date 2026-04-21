namespace Macierze
{
    partial class UserControl2
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
            numThreads = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThreads).BeginInit();
            SuspendLayout();
            // 
            // numSize
            // 
            numSize.Location = new Point(44, 105);
            numSize.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(120, 23);
            numSize.TabIndex = 0;
            numSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numThreads
            // 
            numThreads.Location = new Point(44, 169);
            numThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numThreads.Name = "numThreads";
            numThreads.Size = new Size(120, 23);
            numThreads.TabIndex = 1;
            numThreads.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 87);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Rozmiar macierzy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 151);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Ilość wątków";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 231);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 5;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(227, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(918, 619);
            listBox1.TabIndex = 6;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numThreads);
            Controls.Add(numSize);
            Name = "UserControl2";
            Size = new Size(1158, 669);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThreads).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSize;
        private NumericUpDown numThreads;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
    }
}
