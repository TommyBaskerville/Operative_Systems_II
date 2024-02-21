using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new modificar().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new agregar().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new eliminar().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new mostrar().ShowDialog();
        }
    }
}
