namespace Macierze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 view = new UserControl1();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 view = new UserControl2();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 view = new UserControl3();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }
    }
}
