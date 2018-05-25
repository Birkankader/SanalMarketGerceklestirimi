using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class SuperMarket
    {
        public List<KategoriBST> kategoriler { get; set; }
        public HashMap Hash { get; set; }
        public MinHeap MinHeap { get; set; }
        public List<Urun> urunler { get; set; }
        public int Boyut { get; set; }
        public decimal Gelir { get; set; }
        public decimal Gider { get; set; }

        public SuperMarket()
        {
            Boyut = 80; 
            kategoriler = new List<KategoriBST>();
            Hash = new HashMap(Boyut);
            urunler = new List<Urun>();
            MinHeap = new MinHeap(200);
        }

        public void HasheUrunEkle(Urun urun, string Aciklama)
        {
            Hash.Ekle(Aciklama,urun);
        }

        public void UrunEkle(Urun urun, string UrunTipi, string Kategori)
        {
            bool Eklimi = false;
            foreach (var item in kategoriler)
            {
                if (item.KategoriAdi == Kategori)
                {
                    Eklimi = true;
                    item.Ekle(UrunTipi,urun);
                    urunler.Add(urun);
                }
            }

            if (!Eklimi)
            {
                KategoriBST kategori = new KategoriBST();
                kategori.KategoriAdi = Kategori;
                kategori.Ekle(UrunTipi, urun);
                kategoriler.Add(kategori);
                urunler.Add(urun);
            }
        }
        public void MinHeapDoldur()
        {
            for (int i = 0; i < urunler.Count; i++)
            {
                MinHeap.add(urunler[i]);
            }
        }

        public List<Urun> MinHeapListesi()
        {
            List<Urun> products = new List<Urun>();
            int length = MinHeap.Size;

            for (int i = 0; i < length; i++)
            {
                products.Add(MinHeap.pop());
            }

            return products;
        }

        public void KategoriEkle(string Kategori)
        {
            bool Eklimi = false;
            for (int i = 0; i < kategoriler.Count; i++)
            {
                if (kategoriler[i].KategoriAdi.Equals(Kategori))
                    Eklimi = true;
            }

            if (!Eklimi)
            {
                KategoriBST kategori = new KategoriBST();
                kategori.KategoriAdi = Kategori;

                kategoriler.Add(kategori);
            }
        }

        public Urun HashtenSil(string Aciklama)
        {
            return Hash.Sil(Aciklama);
        }


        public Urun BTSUrunSil(string Aciklama)
        {

            Urun urun = null;
            foreach (var item in kategoriler)
            {
                urun = item.Sil(Aciklama);
                if (urun != null)
                    break;
            }
            
            return urun;
        }

        public Urun ListedenSil(string Aciklama)
        {
            foreach (var item in urunler)
            {
                if (item.Aciklama == Aciklama)
                {
                    Urun urun = item;
                    urunler.Remove(urun);
                    return urun;
                }

            }
            return null;

        }

        public List<Urun> HashAra(string Aciklama)
        {
            return Hash.Ara(Aciklama);
        }

        public Urun UrunAra(string Aciklama)
        {
            List<Urun> urunler = Hash.Ara(Aciklama);
            if (urunler == null)
                return null;

            foreach (var item in urunler)
            {
                if (item.Aciklama == Aciklama)
                    return item;
            }
            return null;
        }


        public Urun UrunSiparis(string Aciklama)
        {
            List<Urun> urunler = HashAra(Aciklama);
            foreach (var item in urunler)
            {
                if (item.Aciklama == Aciklama)
                    return item;
            }
            return null;
        }

        public List<UrunListe> KategoriListePreOrder(string KategoriAdi)
        {
            foreach (var item in kategoriler)
            {
                if (item.KategoriAdi == KategoriAdi)
                {
                    item.PreOrder();
                    return item.Yazdir();
                }
            }
            return null;
        }

        public List<UrunListe> KategoriListeInOrder(string KategoriAdi)
        {
            foreach (var item in kategoriler)
            {
                if (item.KategoriAdi == KategoriAdi)
                {
                    item.InOrder();
                    return item.Yazdir();
                }
            }
            return null;
        }

        public List<UrunListe> KategoriListePostOrder(string KategoriAdi)
        {
            foreach (var item in kategoriler)
            {
                if (item.KategoriAdi == KategoriAdi)
                {
                    item.PostOrder();
                    return item.Yazdir();
                }
            }
            return null;
        }

        public bool UrunGuncelle(string Aciklama, string UrunAdi , string Marka, string Model, int Miktar,
             decimal Maliyet, decimal Fiyat)
        {
            List<Urun> urunler = Hash.Ara(Aciklama);
            Urun urun = null;


            foreach (var item in urunler)
            {
                if (item.Aciklama == Aciklama)
                    urun = item;
            }

            if (urun == null)
                return false;

            urun.UrunAdi = UrunAdi;
            urun.Marka = Marka;
            urun.Model = Model;
            urun.Miktar = Miktar;
            urun.Maliyet = Maliyet;
            urun.Fiyat = Fiyat;
            return true;

        } 

        public List<Urun> HashListele()
        {
            return Hash.Listele();
        }

        public void GelirGiderHesapla() 
        {
            decimal gelir = 0;
            decimal gider = 0;
            for (int i = 0; i < kategoriler.Count; i++)
            {
                List<UrunListe> kategoriListe = KategoriListePostOrder(kategoriler[i].KategoriAdi);
                for (int j = 0; j < kategoriListe.Count; j++)
                {
                    List<Urun> urunler = kategoriListe[j].urunler;
                    for (int k = 0; k < urunler.Count; k++)
                    {
                        gelir += urunler[k].Fiyat;
                        gider += urunler[k].Maliyet;
                    }
                }

            }

            this.Gelir = gelir;
            this.Gider = gider;
        }
    }
}
