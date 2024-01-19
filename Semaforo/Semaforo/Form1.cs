namespace Semaforo
{
    public partial class Form1 : Form
    {
        int tick = 0;
        int car = 0;
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
                pictureBox1.Image = Properties.Resources.Semaforo3;
            }
            else if (tick <= 8)
            {
                pictureBox1.Image = Properties.Resources.Semaforo2;
            }
            else if (tick <= 9)
            {
                pictureBox1.Image = Properties.Resources.Semaforo0;
            }
            else if (tick <= 10)
            {
                pictureBox1.Image = Properties.Resources.Semaforo2;
            }
            else if (tick <= 11)
            {
                pictureBox1.Image = Properties.Resources.Semaforo0;
            }
            else if (tick <= 12)
            {
                pictureBox1.Image = Properties.Resources.Semaforo2;
            }
            else if (tick <= 13)
            {
                pictureBox1.Image = Properties.Resources.Semaforo0;
            }
            else if (tick < 19)
            {
                pictureBox1.Image = Properties.Resources.Semaforo;
            }
            else if (tick == 19)
            {
                tipo = "alto";
                pictureBox1.Image = Properties.Resources.Semaforo0;
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
                car = -500;
            }
            pictureBox2.Location = new Point(car, 600);
        }
    }
}
