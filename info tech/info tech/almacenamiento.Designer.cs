﻿
namespace info_tech
{
    partial class almacenamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(almacenamiento));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblTipo1 = new System.Windows.Forms.Label();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.lblAlmacenamiento1 = new System.Windows.Forms.Label();
            this.lblAlmacenamiento2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picalmacenamiento1 = new System.Windows.Forms.PictureBox();
            this.picalmacenamiento2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picalmacenamiento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picalmacenamiento2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 189);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seagate barracuda",
            "WD green"});
            this.comboBox1.Location = new System.Drawing.Point(62, 479);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Seagate barracuda",
            "WD green"});
            this.comboBox2.Location = new System.Drawing.Point(550, 479);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblTipo1
            // 
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Location = new System.Drawing.Point(65, 600);
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(31, 13);
            this.lblTipo1.TabIndex = 3;
            this.lblTipo1.Text = "Tipo:";
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Location = new System.Drawing.Point(547, 600);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(31, 13);
            this.lblTipo2.TabIndex = 4;
            this.lblTipo2.Text = "Tipo:";
            // 
            // lblAlmacenamiento1
            // 
            this.lblAlmacenamiento1.AutoSize = true;
            this.lblAlmacenamiento1.Location = new System.Drawing.Point(59, 631);
            this.lblAlmacenamiento1.Name = "lblAlmacenamiento1";
            this.lblAlmacenamiento1.Size = new System.Drawing.Size(88, 13);
            this.lblAlmacenamiento1.TabIndex = 5;
            this.lblAlmacenamiento1.Text = "Almacenamiento:";
            // 
            // lblAlmacenamiento2
            // 
            this.lblAlmacenamiento2.AutoSize = true;
            this.lblAlmacenamiento2.Location = new System.Drawing.Point(547, 631);
            this.lblAlmacenamiento2.Name = "lblAlmacenamiento2";
            this.lblAlmacenamiento2.Size = new System.Drawing.Size(88, 13);
            this.lblAlmacenamiento2.TabIndex = 6;
            this.lblAlmacenamiento2.Text = "Almacenamiento:";
            this.lblAlmacenamiento2.Click += new System.EventHandler(this.lblAlmacenamiento2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picalmacenamiento1
            // 
            this.picalmacenamiento1.Location = new System.Drawing.Point(62, 530);
            this.picalmacenamiento1.Name = "picalmacenamiento1";
            this.picalmacenamiento1.Size = new System.Drawing.Size(100, 50);
            this.picalmacenamiento1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picalmacenamiento1.TabIndex = 8;
            this.picalmacenamiento1.TabStop = false;
            // 
            // picalmacenamiento2
            // 
            this.picalmacenamiento2.Location = new System.Drawing.Point(550, 530);
            this.picalmacenamiento2.Name = "picalmacenamiento2";
            this.picalmacenamiento2.Size = new System.Drawing.Size(100, 50);
            this.picalmacenamiento2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picalmacenamiento2.TabIndex = 9;
            this.picalmacenamiento2.TabStop = false;
            // 
            // almacenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.picalmacenamiento2);
            this.Controls.Add(this.picalmacenamiento1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAlmacenamiento2);
            this.Controls.Add(this.lblAlmacenamiento1);
            this.Controls.Add(this.lblTipo2);
            this.Controls.Add(this.lblTipo1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "almacenamiento";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.almacenamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picalmacenamiento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picalmacenamiento2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTipo1;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.Label lblAlmacenamiento1;
        private System.Windows.Forms.Label lblAlmacenamiento2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picalmacenamiento1;
        private System.Windows.Forms.PictureBox picalmacenamiento2;
    }
}