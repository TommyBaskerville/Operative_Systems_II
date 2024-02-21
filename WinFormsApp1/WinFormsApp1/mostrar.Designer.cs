namespace WinFormsApp1
{
    partial class mostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Clave = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Clave, Nombre, Edad, Fecha, Salario });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 8;
            Clave.Name = "Clave";
            Clave.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            Edad.Width = 150;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario";
            Salario.MinimumWidth = 8;
            Salario.Name = "Salario";
            Salario.Width = 150;
            // 
            // mostrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "mostrar";
            Text = "mostrar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Salario;
    }
}