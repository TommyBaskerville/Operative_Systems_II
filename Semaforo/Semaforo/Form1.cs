namespace Semaforo
{
    public partial class Form1 : Form
    {
        int tick = 0;
        int car = 0;
        string tipo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick <= 6)
            {
                pictureBox1.Image = Properties.Resources.Semaforo31;
            }
            else if (tick <= 8)
            {
                pictureBox1.Image = Properties.Resources.Semaforo21;
            }
            else if (tick <= 9)
            {
                pictureBox1.Image = Properties.Resources.Semaforo01;
            }
            else if (tick <= 10)
            {
                pictureBox1.Image = Properties.Resources.Semaforo21;
            }
            else if (tick <= 11)
            {
                pictureBox1.Image = Properties.Resources.Semaforo01;
            }
            else if (tick <= 12)
            {
                pictureBox1.Image = Properties.Resources.Semaforo21;
            }
            else if (tick <= 13)
            {
                pictureBox1.Image = Properties.Resources.Semaforo01;
            }
            else if (tick < 19)
            {
                pictureBox1.Image = Properties.Resources.Semaforo1;
            }
            else if (tick == 19)
            {
                tipo = "alto";
                pictureBox1.Image = Properties.Resources.Semaforo01;
                tick = -1;
            }
            tick++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            car += 10;
            if (car >= this.Width)
            {
                car = -250;
            }
            pictureBox2.Location = new Point(car, 400);
        }
    }
}
