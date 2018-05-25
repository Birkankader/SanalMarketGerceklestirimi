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
    public partial class frmMusteri : Form
    {
        public Musteri Musteri { get; set; }
        public SuperMarket Market { get; set; }
        public frmGiris Giris { get; set; }
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
                lstBulunanlar.Items.Add(item);
            }
        }
        private void listTemizle()
        {
            lstBulunanlar.Items.Clear();
        }

        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string temp = txtUrunAra.Text;
            List<Urun> bulunanNormal = new List<Urun>();
            if (temp =="")
                MessageBox.Show("Bu alanı boş geçmeyiniz..");

            Urun bulunanUrun = Market.UrunAra(temp);

            if(bulunanUrun == null)
                MessageBox.Show("Ürün bulunamadı..");
            else
            {  
                bulunanNormal.Add(bulunanUrun);   
            }
            listTemizle();
            foreach (var k in bulunanNormal)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstBulunanlar.Items.Add(item);
            }
        }

        private void btnHashAra_Click(object sender, EventArgs e)
        {
            string temp = txtUrunHashAra.Text;

            if(temp=="")
                MessageBox.Show("Bu alanı boş geçmeyiniz..");

            List<Urun> urunler = Market.HashAra(temp);
            if(urunler== null)
                MessageBox.Show("Ürün bulunamadı..");
            listTemizle();
            foreach (var k in urunler)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstBulunanlar.Items.Add(item);
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string temp = txtSepeteEkle.Text;
            if(temp == null)
                MessageBox.Show("Bu alanı boş geçmeyiniz..");
            Musteri.AlisverisListesi.Add(Market.UrunSiparis(temp));
            listTemizle();
            lstSepet.Clear();
            foreach (var k in Musteri.AlisverisListesi)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstSepet.Items.Add(item);
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            decimal fiyatDusuk = Convert.ToDecimal(txtEnDusuk.Text);
            decimal fiyatYuksek = Convert.ToDecimal(txtEnYuksek.Text);

            Market.MinHeapDoldur();
            List<Urun> urunler = Market.MinHeapListesi();

            List<Urun> fiyatListe = new List<Urun>();
            for (int i = 0; i < urunler.Count; i++)
            {
                if (fiyatDusuk <= urunler[i].Fiyat && fiyatYuksek >= urunler[i].Fiyat)
                {
                    fiyatListe.Add(urunler[i]);
                }
            }
            listTemizle();
            lstBulunanlar.Clear();
            foreach (var k in fiyatListe)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstBulunanlar.Items.Add(item);
            }

        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            string bilgi = txtSepetCikar.Text;

            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Urun product = Musteri.UrunVarmi(bilgi);
            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
                return;
            }

            Musteri.UrunSil(bilgi);
            MessageBox.Show("Ürün Sepetten Çıkarıldı.");
            listTemizle();
            lstSepet.Clear();
            foreach (var k in Musteri.AlisverisListesi)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstSepet.Items.Add(item);
            }
        }

        private void btnUrunAras_Click(object sender, EventArgs e)
        {
            string temp = txtUrunAras.Text;
            List<Urun> bulunanNormal = new List<Urun>();
            if (temp == "")
                MessageBox.Show("Bu alanı boş geçmeyiniz..");

            Urun bulunanUrun = Market.UrunAra(temp);

            if (bulunanUrun == null)
                MessageBox.Show("Ürün bulunamadı..");
            else
            {
                bulunanNormal.Add(bulunanUrun);
            }
           
            foreach (var k in bulunanNormal)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstSiparis.Items.Add(item);
            }
        }

        private void btnSepeteEkles_Click(object sender, EventArgs e)
        {
            string temp = txtSepeteEkle.Text;
            if (temp == null)
                MessageBox.Show("Bu alanı boş geçmeyiniz..");
            Musteri.AlisverisListesi.Add(Market.UrunSiparis(temp));
            listTemizle();
            lstSepet.Clear();
            foreach (var k in Musteri.AlisverisListesi)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstSepet.Items.Add(item);
            }
        }

        private void btnUrunAraHeaps_Click(object sender, EventArgs e)
        {
            int adet = 0;
            adet = Convert.ToInt32(txtUrunAraHeaps.Text);

            Market.MinHeapDoldur();
            List<Urun> urunler = Market.MinHeapListesi();

            if (urunler == null)
            {
                MessageBox.Show("Markette Ürün Bulumamaktadır...");
            }

            List<Urun> fiyatListe = new List<Urun>();
            foreach (var item in urunler)
            {
                fiyatListe.Add(item);
            }
            if (fiyatListe.Count == 0)
            {
                MessageBox.Show("Ürün Bulunmamaktadır..");
                return;
            }
            lstSiparis.Clear();
            foreach (var k in fiyatListe)
            {
                string[] a = new string[] { k.UrunAdi, k.Marka, k.Model, k.Miktar.ToString(),
                    k.Fiyat.ToString(), k.Aciklama };

                ListViewItem item = new ListViewItem(a[0]);
                item.SubItems.Add(a[1]);
                item.SubItems.Add(a[2]);
                item.SubItems.Add(a[3]);
                item.SubItems.Add(a[4]);
                item.SubItems.Add(a[5]);
                lstSiparis.Items.Add(item);
            }
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            if (Musteri.AlisverisListesi.Count == 0)
            {
                MessageBox.Show("Sepetinizde ürün yok.");
                return;
            }
            Musteri.HepsiniAl();
            MessageBox.Show("Tüm ürünler satın alındı");
            listTemizle();
            lstSepet.Clear();
           
        }
    }
}
