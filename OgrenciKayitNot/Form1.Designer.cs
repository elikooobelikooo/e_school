namespace OgrenciKayitNot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MSKOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.TxtxOgretmenSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MSKOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MSKOgretmenNumara);
            this.groupBox1.Controls.Add(this.BtnOgretmenGiris);
            this.groupBox1.Controls.Add(this.TxtxOgretmenSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogretmen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MSKOgretmenNumara
            // 
            this.MSKOgretmenNumara.Location = new System.Drawing.Point(220, 31);
            this.MSKOgretmenNumara.Mask = "0000";
            this.MSKOgretmenNumara.Name = "MSKOgretmenNumara";
            this.MSKOgretmenNumara.Size = new System.Drawing.Size(100, 20);
            this.MSKOgretmenNumara.TabIndex = 6;
            this.MSKOgretmenNumara.ValidatingType = typeof(int);
            this.MSKOgretmenNumara.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(220, 110);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(100, 23);
            this.BtnOgretmenGiris.TabIndex = 5;
            this.BtnOgretmenGiris.Text = "Giris";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = true;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // TxtxOgretmenSifre
            // 
            this.TxtxOgretmenSifre.Location = new System.Drawing.Point(220, 67);
            this.TxtxOgretmenSifre.Name = "TxtxOgretmenSifre";
            this.TxtxOgretmenSifre.PasswordChar = '.';
            this.TxtxOgretmenSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtxOgretmenSifre.TabIndex = 4;
            this.TxtxOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MSKOgrenciNumara);
            this.groupBox2.Controls.Add(this.BtnOgrenciGiris);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.TxtOgrenciSifre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ogrenci";
            // 
            // MSKOgrenciNumara
            // 
            this.MSKOgrenciNumara.Location = new System.Drawing.Point(231, 38);
            this.MSKOgrenciNumara.Mask = "0000";
            this.MSKOgrenciNumara.Name = "MSKOgrenciNumara";
            this.MSKOgrenciNumara.Size = new System.Drawing.Size(100, 20);
            this.MSKOgrenciNumara.TabIndex = 7;
            this.MSKOgrenciNumara.ValidatingType = typeof(int);
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(231, 114);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(100, 23);
            this.BtnOgrenciGiris.TabIndex = 10;
            this.BtnOgrenciGiris.Text = "Giris";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = true;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TxtOgrenciSifre
            // 
            this.TxtOgrenciSifre.Location = new System.Drawing.Point(231, 71);
            this.TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            this.TxtOgrenciSifre.PasswordChar = '.';
            this.TxtOgrenciSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtOgrenciSifre.TabIndex = 9;
            this.TxtOgrenciSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(464, 439);
            this.MinimumSize = new System.Drawing.Size(464, 439);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOgretmenGiris;
        private System.Windows.Forms.TextBox TxtxOgretmenSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOgrenciGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtOgrenciSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MSKOgretmenNumara;
        private System.Windows.Forms.MaskedTextBox MSKOgrenciNumara;
    }
}

