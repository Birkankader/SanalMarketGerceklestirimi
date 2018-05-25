using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketGerceklestirimi
{
    public partial class frmPersonel : Form
    {
        public Personel Personel { get; set; }
        public SuperMarket Market { get; set; }
        public frmGiris Giris { get; set; }
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            foreach (var k in Market.urunler)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstUrunler.Items.Add(item);
            }
        }
        private void listTemizle()
        {
            lstUrunler.Items.Clear();
        }
        private void txtTemizle()
        {
            txtUrunAd.Text = null;
            txtUrunMarka.Text = null;
            txtUrunModel.Text = null;
            txtUrunMiktar.Text= null;
            txtUrunMaliyet.Text= null;
            txtUrunFiyat.Text= null;
            txturunAciklama.Text= null;
            txtUrunTipi.Text= null;
            cmbUrunKategori.SelectedItem = null;
            txtUrunAciklamasiSil.Text = null;
            txtKategoriEkle.Text = null;
        }
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtUrunEkle_Click(object sender, EventArgs e)
        {
            string Ad = txtUrunAd.Text;
            string marka = txtUrunMarka.Text;
            string model = txtUrunModel.Text;
            int miktar = Convert.ToInt32(txtUrunMiktar.Text);
            int maliyet = Convert.ToInt32(txtUrunMaliyet.Text);
            decimal fiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            string aciklama = txturunAciklama.Text;
            string urunTipi = txtUrunTipi.Text;
            string kategori = cmbUrunKategori.SelectedItem.ToString();

            Urun urun = new Urun
            {
                UrunAdi = Ad,
                Marka = marka,
                Model = model,
                Miktar = miktar,
                Maliyet = maliyet,
                Fiyat = fiyat,
                Aciklama = aciklama,
                UrunTipi = urunTipi
            };

            Market.UrunEkle(urun,urunTipi,kategori);
            Market.HasheUrunEkle(urun,aciklama);
            listTemizle();
            Listele();

            txtTemizle();
        }

        private void txtUrunGuncelle_Click(object sender, EventArgs e)
        {
            string Ad = txtUrunAd.Text;
            string marka = txtUrunMarka.Text;
            string model = txtUrunModel.Text;
            int miktar = Convert.ToInt32(txtUrunMiktar.Text);
            int maliyet = Convert.ToInt32(txtUrunMaliyet.Text);
            decimal fiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            string aciklama = txturunAciklama.Text;
            string urunTipi = txtUrunTipi.Text;


            if (Ad=="" || marka == "" || model == "" || aciklama == "" || urunTipi == "")
            {
                MessageBox.Show("Boş Alan Bırakamazsınız..");
            }

            if (Market.UrunGuncelle(aciklama, Ad, marka, model, miktar, maliyet,fiyat))
            {
                MessageBox.Show("Güncelleme Başarılı..");
            }
            else
            {
                MessageBox.Show("Güncelleme Yapılamadı..");
            }

            listTemizle();
            Listele();

            txtTemizle();
        }
        
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            string aciklama = "";
            aciklama = txtUrunAciklamasiSil.Text;

            if(aciklama =="")
                MessageBox.Show("Açıklama boş olamaz..");
            Urun urun = Market.UrunAra(aciklama);

            if (urun == null)
            {
                MessageBox.Show("Bu ürün bulunamadı..");
            }
            Market.urunler.Remove(urun);
            Market.BTSUrunSil(aciklama);
            Market.HashtenSil(aciklama);
            listTemizle();
            Listele();
            txtTemizle();

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategoritxt = txtKategoriEkle.Text;

            if (kategoritxt=="")
            {
                MessageBox.Show("Bu alanı boş bırakamazsınız..");
                return;
            }

            cmbUrunKategori.Items.Add(kategoritxt);
            Market.KategoriEkle(kategoritxt);
            MessageBox.Show("Kategori eklendi..");
        }

        private void btnGGHesapla_Click(object sender, EventArgs e)
        {
            Market.GelirGiderHesapla();
            lblGelir.Text = Market.Gelir.ToString();
            lblGider.Text = Market.Gider.ToString();
            lblDurum.Text = (Market.Gelir - Market.Gider).ToString();
        }
    }
}
