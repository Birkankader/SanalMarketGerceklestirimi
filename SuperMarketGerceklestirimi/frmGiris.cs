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
    public partial class frmGiris : Form
    {
        private SuperMarket market;
        private Personel personel;
        private Musteri musteri;
        public frmGiris()
        {
            InitializeComponent(); 
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            if (txtPersonelKullanici.Text == personel.KullaniciAdi && txtPersonelSifre.Text == personel.Sifre)
            {
                frmPersonel form = new frmPersonel();
                form.Market = this.market;
                form.Personel = personel;
                form.Giris = this;
                this.Hide();
                form.Show();
            }       
        }

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            frmMusteri form = new frmMusteri();
            form.Market = this.market;
            form.Musteri = this.musteri;
            form.Giris = this;
            this.Hide();
            form.Show();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            market = new SuperMarket();

            musteri = new Musteri()
            {
                Ad = "Birkan",
                KullaniciAdi = "admin",
                Sifre = "admin"
            };
            musteri.Market = market;

            personel = new Personel()
            {
                Ad = "Birkan",
                KullaniciAdi = "admin",
                Sifre = "admin"
            };

            personel.Market = market;


            Urun u = new Urun()
            {
                UrunAdi = "Iphone 6S",
                Marka = "Apple",
                Model = "6S",
                UrunTipi = "Telefon",
                Maliyet = 150,
                Fiyat = 1000,
                Miktar = 50,
                Aciklama = "Telefon"
            };
            Urun u1 = new Urun()
            {
                UrunAdi = "Macbook Pro",
                Marka = "Apple",
                Model = "Macbook",
                UrunTipi = "Bilgisayar",
                Maliyet = 1500,
                Fiyat = 2000,
                Miktar = 50,
                Aciklama = "Bilgisayar"
            };
            Urun u2 = new Urun()
            {
                UrunAdi = "Macbook Air",
                Marka = "Apple",
                Model = "Macbook",
                UrunTipi = "Bilgisayar",
                Maliyet = 1000,
                Fiyat = 1500,
                Miktar = 50,
                Aciklama = "Bilgisayar"
            };
            Urun u3 = new Urun()
            {
                UrunAdi = "Coca Cola Zero",
                Marka = "Coca Cola",
                Model = "Zero",
                UrunTipi = "İçecek",
                Maliyet = 1,
                Fiyat = 5,
                Miktar = 500,
                Aciklama = "İçecek"
            };
            market.UrunEkle(u2, u2.UrunTipi,"Bilgisayar");
            market.HasheUrunEkle(u2, u2.Aciklama);
            market.UrunEkle(u, u.UrunTipi, "Telefon");
            market.HasheUrunEkle(u, u.Aciklama);
            market.UrunEkle(u1, u1.UrunTipi, "Bilgisayar");
            market.HasheUrunEkle(u1, u1.Aciklama);
            market.UrunEkle(u2, u2.UrunTipi, "Bilgisayar");
            market.HasheUrunEkle(u2, u2.Aciklama);
        }
    }
}
