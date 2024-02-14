using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Letter : Form
    {
        string fichero = "";
        private Stream url;

        public Letter()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = @"C:\Users\DELL\OneDrive - Benemérita Universidad Autónoma de Puebla";
            this.openFileDialog1.DefaultExt = "BUAP";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fichero = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fichero);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        public void guardarComo()
        {
            this.saveFileDialog1.InitialDirectory = @"C:\Users\DELL\OneDrive - Benemérita Universidad Autónoma de Puebla";
            this.saveFileDialog1.DefaultExt = "BUAP";
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guardarTodo(saveFileDialog1.FileName);               
                fichero = saveFileDialog1.FileName;
                
            }
        }
        public void guardarTodo(string fichero)
        {
            try
            {
                StreamWriter sw = new StreamWriter(url);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fichero == "")
            {
                guardarComo();
            }
            else
            {
                guardarTodo(fichero);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();
            printDocument1.PrinterSettings = printerSettings;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Rectangle(0,10,200,20));
        }
    }
}
