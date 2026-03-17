using Plecak;

namespace GUI
{
    public partial class Plecak : Form
    {
        public Plecak()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);
            int seed = int.Parse(textBox3.Text);
            int capacity = int.Parse(textBox4.Text);
            Problem problem = new Problem(n, seed);
            textBox1.Text = problem.ToString();
            Result wynik = problem.Solve(capacity);
            textBox5.Text = wynik.ToString();

        }

        private void Plecak_Load(object sender, EventArgs e)
        {

        }
    }
}
