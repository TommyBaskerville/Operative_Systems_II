namespace Cronometro
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
