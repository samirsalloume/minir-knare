using System.Diagnostics.Tracing;

namespace miniräknare
{
    public partial class Form2 : Form

    {
        double n1;
        double n2;
        double result;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 =Convert.ToDouble(nr1.Text);
            n2 =Convert.ToDouble(nr2.Text);
            result = n1 + n2;
            res.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(nr1.Text);
            n2 = Convert.ToDouble(nr2.Text);
            result = n1 - n2;
            res.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(nr1.Text);
            n2 = Convert.ToDouble(nr2.Text);
            result = n1 * n2;
            res.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(nr1.Text);
            n2 = Convert.ToDouble(nr2.Text);
            result = n1 / n2;
            res.Text = Convert.ToString(result);
            
        }

        private void nr1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nr2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void on_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}