﻿namespace SistemasVentas.VISTA.InterfazInicioSesionVista
{
    partial class InterfazinicioSesionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazinicioSesionMenu));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 161);
            label1.Name = "label1";
            label1.Size = new Size(182, 50);
            label1.TabIndex = 5;
            label1.Text = "SISTEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 211);
            label2.Name = "label2";
            label2.Size = new Size(163, 50);
            label2.TabIndex = 6;
            label2.Text = "VENTAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(339, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 373);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 24);
            label3.Name = "label3";
            label3.Size = new Size(235, 30);
            label3.TabIndex = 8;
            label3.Text = "NOMBRE DE USUARIO";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 23);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 136);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 10;
            label4.Text = "CONTRASEÑA";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(83, 292);
            button1.Name = "button1";
            button1.Size = new Size(254, 34);
            button1.TabIndex = 12;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // InterfazinicioSesionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "InterfazinicioSesionMenu";
            Text = "InterfazinicioSesionMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
    }
}