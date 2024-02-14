namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        }
    }
}
