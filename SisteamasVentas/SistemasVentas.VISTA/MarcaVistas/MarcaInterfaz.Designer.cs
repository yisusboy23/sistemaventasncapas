﻿namespace SistemasVentas.VISTA.MarcaVistas
{
    partial class MarcaInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaInterfaz));
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(424, 401);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(27, 424);
            button1.Name = "button1";
            button1.Size = new Size(59, 49);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(220, 346);
            button2.Name = "button2";
            button2.Size = new Size(59, 49);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.DialogResult = DialogResult.OK;
            button4.Location = new Point(220, 424);
            button4.Name = "button4";
            button4.Size = new Size(59, 49);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(25, 346);
            button3.Name = "button3";
            button3.Size = new Size(59, 49);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 100);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(33, 20);
            label2.Name = "label2";
            label2.Size = new Size(137, 47);
            label2.TabIndex = 0;
            label2.Text = "MARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 320);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 17;
            label3.Text = "INSERTAR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 18;
            label1.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 320);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 19;
            label4.Text = "LIMPIAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 398);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 20;
            label5.Text = "EDITAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(202, 398);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 21;
            label6.Text = "ELIMINAR";
            // 
            // MarcaInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(759, 519);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MarcaInterfaz";
            Text = "MarcaInterfaz";
            Load += MarcaInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}