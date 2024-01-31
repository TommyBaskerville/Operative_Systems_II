using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_usuario
{
    public partial class UserControl1 : UserControl
    {
        int tamano;
        int incremento;
        int tempo;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }

            incremento = Convert.ToInt32(textBox1.Text);

            if (textBox2.Text == "")
            {
                textBox2.Text = "100";
            }

            tamano = Convert.ToInt32(textBox2.Text);

            if (incremento < tamano)
            {
                progressBar1.Step = incremento;
                progressBar1.Maximum = tamano;
                tempo = incremento;
                timer1.Start();
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("El tamano no puede ser que el incremento");
                textBox1.Text = "";
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (tempo >= tamano)
            {
                timer1.Stop();
                progressBar1.Value = tamano;
                textBox1.Enabled = true; textBox2.Enabled = true; button1.Enabled = true;
            }
            else
            {
                progressBar1.Value = tempo;
            }
            tempo += tempo;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {

                textBox1.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                try
                {
                    int i = Convert.ToInt32(textBox2.Text);
                }
                catch (Exception ex)
                {

                    textBox2.Text = "";
                }
            }
        }
    }
}
