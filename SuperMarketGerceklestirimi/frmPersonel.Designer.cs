namespace SuperMarketGerceklestirimi
{
    partial class frmPersonel
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
            this.tabRapor = new System.Windows.Forms.TabControl();
            this.tabUrunIslemler = new System.Windows.Forms.TabPage();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrunAciklamasiSil = new System.Windows.Forms.TextBox();
            this.txtKategoriEkle = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunTipi = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txturunAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.txtUrunMiktar = new System.Windows.Forms.TextBox();
            this.txtUrunModel = new System.Windows.Forms.TextBox();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGider = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGGHesapla = new System.Windows.Forms.Button();
            this.tabRapor.SuspendLayout();
            this.tabUrunIslemler.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRapor
            // 
            this.tabRapor.Controls.Add(this.tabUrunIslemler);
            this.tabRapor.Controls.Add(this.tabPage2);
            this.tabRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRapor.Location = new System.Drawing.Point(0, 0);
            this.tabRapor.Name = "tabRapor";
            this.tabRapor.SelectedIndex = 0;
            this.tabRapor.Size = new System.Drawing.Size(835, 325);
            this.tabRapor.TabIndex = 0;
            // 
            // tabUrunIslemler
            // 
            this.tabUrunIslemler.Controls.Add(this.lstUrunler);
            this.tabUrunIslemler.Controls.Add(this.label7);
            this.tabUrunIslemler.Controls.Add(this.btnUrunGuncelle);
            this.tabUrunIslemler.Controls.Add(this.label11);
            this.tabUrunIslemler.Controls.Add(this.txtUrunAciklamasiSil);
            this.tabUrunIslemler.Controls.Add(this.txtKategoriEkle);
            this.tabUrunIslemler.Controls.Add(this.btnKategoriEkle);
            this.tabUrunIslemler.Controls.Add(this.label10);
            this.tabUrunIslemler.Controls.Add(this.btnUrunSil);
            this.tabUrunIslemler.Controls.Add(this.label9);
            this.tabUrunIslemler.Controls.Add(this.txtUrunTipi);
            this.tabUrunIslemler.Controls.Add(this.btnUrunEkle);
            this.tabUrunIslemler.Controls.Add(this.cmbUrunKategori);
            this.tabUrunIslemler.Controls.Add(this.label8);
            this.tabUrunIslemler.Controls.Add(this.label6);
            this.tabUrunIslemler.Controls.Add(this.label5);
            this.tabUrunIslemler.Controls.Add(this.label4);
            this.tabUrunIslemler.Controls.Add(this.label3);
            this.tabUrunIslemler.Controls.Add(this.label2);
            this.tabUrunIslemler.Controls.Add(this.label1);
            this.tabUrunIslemler.Controls.Add(this.txturunAciklama);
            this.tabUrunIslemler.Controls.Add(this.txtUrunFiyat);
            this.tabUrunIslemler.Controls.Add(this.txtUrunMaliyet);
            this.tabUrunIslemler.Controls.Add(this.txtUrunMiktar);
            this.tabUrunIslemler.Controls.Add(this.txtUrunModel);
            this.tabUrunIslemler.Controls.Add(this.txtUrunMarka);
            this.tabUrunIslemler.Controls.Add(this.txtUrunAd);
            this.tabUrunIslemler.Location = new System.Drawing.Point(4, 22);
            this.tabUrunIslemler.Name = "tabUrunIslemler";
            this.tabUrunIslemler.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunIslemler.Size = new System.Drawing.Size(827, 299);
            this.tabUrunIslemler.TabIndex = 0;
            this.tabUrunIslemler.Text = "Ürün İşlemleri";
            this.tabUrunIslemler.UseVisualStyleBackColor = true;
            // 
            // lstUrunler
            // 
            this.lstUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.Marka,
            this.Model,
            this.Miktar,
            this.Fiyat,
            this.Aciklama});
            this.lstUrunler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.Location = new System.Drawing.Point(259, 78);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(556, 213);
            this.lstUrunler.TabIndex = 84;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.View = System.Windows.Forms.View.Details;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 75;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 75;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 75;
            // 
            // Miktar
            // 
            this.Miktar.Text = "Miktar";
            this.Miktar.Width = 75;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 75;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Ürün Açıklaması";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(133, 268);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(102, 23);
            this.btnUrunGuncelle.TabIndex = 82;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.txtUrunGuncelle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(604, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 81;
            this.label11.Text = "Kategori İsmi";
            // 
            // txtUrunAciklamasiSil
            // 
            this.txtUrunAciklamasiSil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAciklamasiSil.Location = new System.Drawing.Point(462, 8);
            this.txtUrunAciklamasiSil.Name = "txtUrunAciklamasiSil";
            this.txtUrunAciklamasiSil.Size = new System.Drawing.Size(121, 22);
            this.txtUrunAciklamasiSil.TabIndex = 80;
            // 
            // txtKategoriEkle
            // 
            this.txtKategoriEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriEkle.Location = new System.Drawing.Point(694, 8);
            this.txtKategoriEkle.Name = "txtKategoriEkle";
            this.txtKategoriEkle.Size = new System.Drawing.Size(121, 22);
            this.txtKategoriEkle.TabIndex = 79;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.Location = new System.Drawing.Point(694, 40);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(121, 23);
            this.btnKategoriEkle.TabIndex = 78;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(355, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Ürün Açıklaması";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(462, 40);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(121, 23);
            this.btnUrunSil.TabIndex = 76;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Ürün Tipi";
            // 
            // txtUrunTipi
            // 
            this.txtUrunTipi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunTipi.Location = new System.Drawing.Point(114, 205);
            this.txtUrunTipi.Name = "txtUrunTipi";
            this.txtUrunTipi.Size = new System.Drawing.Size(121, 22);
            this.txtUrunTipi.TabIndex = 74;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(15, 268);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(102, 23);
            this.btnUrunEkle.TabIndex = 73;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.txtUrunEkle_Click);
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Giyim",
            "Yapı Market",
            "Bahçe",
            "Yiyecek"});
            this.cmbUrunKategori.Location = new System.Drawing.Point(114, 8);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(174, 25);
            this.cmbUrunKategori.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Ürün Kategorisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ürün Maliyeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ürün Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ürün Modeli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ürün Markası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Ürün Adı";
            // 
            // txturunAciklama
            // 
            this.txturunAciklama.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunAciklama.Location = new System.Drawing.Point(114, 231);
            this.txturunAciklama.Name = "txturunAciklama";
            this.txturunAciklama.Size = new System.Drawing.Size(121, 22);
            this.txturunAciklama.TabIndex = 64;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunFiyat.Location = new System.Drawing.Point(114, 179);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(121, 22);
            this.txtUrunFiyat.TabIndex = 63;
            // 
            // txtUrunMaliyet
            // 
            this.txtUrunMaliyet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunMaliyet.Location = new System.Drawing.Point(114, 153);
            this.txtUrunMaliyet.Name = "txtUrunMaliyet";
            this.txtUrunMaliyet.Size = new System.Drawing.Size(121, 22);
            this.txtUrunMaliyet.TabIndex = 62;
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunMiktar.Location = new System.Drawing.Point(114, 127);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(121, 22);
            this.txtUrunMiktar.TabIndex = 61;
            // 
            // txtUrunModel
            // 
            this.txtUrunModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunModel.Location = new System.Drawing.Point(114, 101);
            this.txtUrunModel.Name = "txtUrunModel";
            this.txtUrunModel.Size = new System.Drawing.Size(121, 22);
            this.txtUrunModel.TabIndex = 60;
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunMarka.Location = new System.Drawing.Point(114, 75);
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(121, 22);
            this.txtUrunMarka.TabIndex = 59;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(114, 49);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(121, 22);
            this.txtUrunAd.TabIndex = 58;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGGHesapla);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rapor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(35, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gelir";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(35, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "Gider";
            // 
            // lblGelir
            // 
            this.lblGelir.AutoSize = true;
            this.lblGelir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelir.Location = new System.Drawing.Point(112, 32);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(55, 21);
            this.lblGelir.TabIndex = 2;
            this.lblGelir.Text = "32423";
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider.Location = new System.Drawing.Point(112, 74);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(37, 21);
            this.lblGider.TabIndex = 3;
            this.lblGider.Text = "535";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(35, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 22);
            this.label16.TabIndex = 4;
            this.label16.Text = "Durum";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(112, 112);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(55, 21);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "32432";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblGelir);
            this.groupBox1.Controls.Add(this.lblGider);
            this.groupBox1.Location = new System.Drawing.Point(272, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir/Gider";
            // 
            // btnGGHesapla
            // 
            this.btnGGHesapla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGGHesapla.Location = new System.Drawing.Point(338, 223);
            this.btnGGHesapla.Name = "btnGGHesapla";
            this.btnGGHesapla.Size = new System.Drawing.Size(128, 31);
            this.btnGGHesapla.TabIndex = 7;
            this.btnGGHesapla.Text = "Hesapla";
            this.btnGGHesapla.UseVisualStyleBackColor = true;
            this.btnGGHesapla.Click += new System.EventHandler(this.btnGGHesapla_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 325);
            this.Controls.Add(this.tabRapor);
            this.Name = "frmPersonel";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.tabRapor.ResumeLayout(false);
            this.tabUrunIslemler.ResumeLayout(false);
            this.tabUrunIslemler.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRapor;
        private System.Windows.Forms.TabPage tabUrunIslemler;
        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Miktar;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUrunAciklamasiSil;
        private System.Windows.Forms.TextBox txtKategoriEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunTipi;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturunAciklama;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunMaliyet;
        private System.Windows.Forms.TextBox txtUrunMiktar;
        private System.Windows.Forms.TextBox txtUrunModel;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGGHesapla;
    }
}