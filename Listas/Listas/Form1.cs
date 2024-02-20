namespace Listas
{
    public partial class Form1 : Form
    {
        private string valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminar();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count -1; i++)
            {
                String valor = dataGridView1.Rows[i].Cells[0].Value.ToString();
                valor += ": " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                valor += ": " + dataGridView1.Rows[i].Cells[2].Value.ToString();
                valor += ": " + dataGridView1.Rows[i].Cells[3].Value.ToString();
                valor = "/n";

            }
            guardarComo(valor);
        }

        public void guardarComo(String valor)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, valor);
            }
        }

        public void abrir()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String valor = System.IO.File.ReadAllText(openFileDialog1.FileName);
                String[] lineas = valor.Split('\n');
                for(int i = 0; i < lineas.Length; i++)
                {
                    String[] datos = lineas[i].Split(':');
                    dataGridView1.Rows.Add(datos);
                }
            }
        }
        
        public void eliminar()
        {
            if(dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
