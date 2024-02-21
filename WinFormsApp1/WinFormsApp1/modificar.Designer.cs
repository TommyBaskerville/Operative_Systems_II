namespace WinFormsApp1
{
    partial class modificar
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(307, 483);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 23;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(137, 483);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 22;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(46, 407);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(370, 31);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 379);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 20;
            label5.Text = "Salario:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(46, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(370, 31);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 284);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 18;
            label4.Text = "Fecha:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(46, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(370, 31);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 191);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 16;
            label3.Text = "Edad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 31);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 31);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 17);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 12;
            label1.Text = "Clave:";
            // 
            // button3
            // 
            button3.Location = new Point(298, 44);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 24;
            button3.Text = "....";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // modificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 553);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "modificar";
            Text = "modificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
    }
}