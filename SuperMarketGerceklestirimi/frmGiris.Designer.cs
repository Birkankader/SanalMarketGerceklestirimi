namespace SuperMarketGerceklestirimi
{
    partial class frmGiris
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
            this.tbGirisForm = new System.Windows.Forms.TabControl();
            this.tbGiris = new System.Windows.Forms.TabPage();
            this.lblGiris = new System.Windows.Forms.Label();
            this.tbPersonel = new System.Windows.Forms.TabPage();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelKullanici = new System.Windows.Forms.TextBox();
            this.tbMusteri = new System.Windows.Forms.TabPage();
            this.btnMusteriGiris = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.txtMusteriKullanici = new System.Windows.Forms.TextBox();
            this.tbGirisForm.SuspendLayout();
            this.tbGiris.SuspendLayout();
            this.tbPersonel.SuspendLayout();
            this.tbMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGirisForm
            // 
            this.tbGirisForm.Controls.Add(this.tbGiris);
            this.tbGirisForm.Controls.Add(this.tbPersonel);
            this.tbGirisForm.Controls.Add(this.tbMusteri);
            this.tbGirisForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGirisForm.Location = new System.Drawing.Point(0, 0);
            this.tbGirisForm.Name = "tbGirisForm";
            this.tbGirisForm.SelectedIndex = 0;
            this.tbGirisForm.Size = new System.Drawing.Size(619, 261);
            this.tbGirisForm.TabIndex = 1;
            // 
            // tbGiris
            // 
            this.tbGiris.BackColor = System.Drawing.Color.Transparent;
            this.tbGiris.Controls.Add(this.lblGiris);
            this.tbGiris.Location = new System.Drawing.Point(4, 22);
            this.tbGiris.Name = "tbGiris";
            this.tbGiris.Padding = new System.Windows.Forms.Padding(3);
            this.tbGiris.Size = new System.Drawing.Size(611, 235);
            this.tbGiris.TabIndex = 0;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGiris.Location = new System.Drawing.Point(114, 65);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(383, 77);
            this.lblGiris.TabIndex = 0;
            this.lblGiris.Text = "Hoşgeldiniz";
            this.lblGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPersonel
            // 
            this.tbPersonel.Controls.Add(this.btnPersonelGiris);
            this.tbPersonel.Controls.Add(this.label5);
            this.tbPersonel.Controls.Add(this.label2);
            this.tbPersonel.Controls.Add(this.label1);
            this.tbPersonel.Controls.Add(this.txtPersonelSifre);
            this.tbPersonel.Controls.Add(this.txtPersonelKullanici);
            this.tbPersonel.Location = new System.Drawing.Point(4, 22);
            this.tbPersonel.Name = "tbPersonel";
            this.tbPersonel.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonel.Size = new System.Drawing.Size(611, 235);
            this.tbPersonel.TabIndex = 1;
            this.tbPersonel.Text = "Personel";
            this.tbPersonel.UseVisualStyleBackColor = true;
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Location = new System.Drawing.Point(276, 160);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(159, 49);
            this.btnPersonelGiris.TabIndex = 9;
            this.btnPersonelGiris.Text = "Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(226, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Personel Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSifre.Location = new System.Drawing.Point(276, 106);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(159, 23);
            this.txtPersonelSifre.TabIndex = 1;
            // 
            // txtPersonelKullanici
            // 
            this.txtPersonelKullanici.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelKullanici.Location = new System.Drawing.Point(276, 80);
            this.txtPersonelKullanici.Name = "txtPersonelKullanici";
            this.txtPersonelKullanici.Size = new System.Drawing.Size(159, 23);
            this.txtPersonelKullanici.TabIndex = 0;
            // 
            // tbMusteri
            // 
            this.tbMusteri.Controls.Add(this.btnMusteriGiris);
            this.tbMusteri.Controls.Add(this.label6);
            this.tbMusteri.Controls.Add(this.label3);
            this.tbMusteri.Controls.Add(this.label4);
            this.tbMusteri.Controls.Add(this.txtMusteriSifre);
            this.tbMusteri.Controls.Add(this.txtMusteriKullanici);
            this.tbMusteri.Location = new System.Drawing.Point(4, 22);
            this.tbMusteri.Name = "tbMusteri";
            this.tbMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tbMusteri.Size = new System.Drawing.Size(611, 235);
            this.tbMusteri.TabIndex = 2;
            this.tbMusteri.Text = "Musteri";
            this.tbMusteri.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.Location = new System.Drawing.Point(276, 160);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(159, 49);
            this.btnMusteriGiris.TabIndex = 8;
            this.btnMusteriGiris.Text = "Giriş";
            this.btnMusteriGiris.UseVisualStyleBackColor = true;
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(245, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Müşteri Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(167, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(167, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSifre.Location = new System.Drawing.Point(276, 106);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.PasswordChar = '*';
            this.txtMusteriSifre.Size = new System.Drawing.Size(159, 23);
            this.txtMusteriSifre.TabIndex = 4;
            // 
            // txtMusteriKullanici
            // 
            this.txtMusteriKullanici.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriKullanici.Location = new System.Drawing.Point(276, 80);
            this.txtMusteriKullanici.Name = "txtMusteriKullanici";
            this.txtMusteriKullanici.Size = new System.Drawing.Size(159, 23);
            this.txtMusteriKullanici.TabIndex = 3;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.tbGirisForm);
            this.Name = "frmGiris";
            this.Text = "SuperMarket";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.tbGirisForm.ResumeLayout(false);
            this.tbGiris.ResumeLayout(false);
            this.tbGiris.PerformLayout();
            this.tbPersonel.ResumeLayout(false);
            this.tbPersonel.PerformLayout();
            this.tbMusteri.ResumeLayout(false);
            this.tbMusteri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbGirisForm;
        private System.Windows.Forms.TabPage tbGiris;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.TabPage tbPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelKullanici;
        private System.Windows.Forms.TabPage tbMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.TextBox txtMusteriKullanici;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMusteriGiris;
        private System.Windows.Forms.Label label6;
    }
}

