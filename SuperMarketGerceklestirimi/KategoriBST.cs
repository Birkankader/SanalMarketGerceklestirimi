using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class KategoriBST
    {
        public KategoriBSTDugum kok;
        public string KategoriAdi { get; set; }

        private List<UrunListe> liste;

        public KategoriBST()
        {
            
        }
        public Urun Sil(string urunAciklamasi)
        {
            return Sil(urunAciklamasi, kok);
        }

        public Urun Sil(string Aciklama, KategoriBSTDugum dugum)
        {
            if (dugum == null)
                return null;

            
            for (int i = 0; i < dugum.Data.Urunler.Count; i++)
            {
                if (dugum.Data.Urunler[i].Aciklama == Aciklama)
                {
                    Urun temp = dugum.Data.Urunler[i];
                    dugum.Data.Urunler.RemoveAt(i);
                    return temp;
                }
            }

            Urun temp1 = Sil(Aciklama, dugum.SolDugum) ?? Sil(Aciklama, dugum.SagDugum);
            return temp1;
        }

        public void Ekle(string UrunTipi, Urun urun)
        {
            bool flag = false;
            KategoriBSTDugum tempParent = new KategoriBSTDugum();
            //Kökten başla ve ilerle
            KategoriBSTDugum tempSearch = kok;

            while (tempSearch != null)
            {           
                tempParent = tempSearch;
                //Deger zaten var, çık.
                
                if (String.Compare(tempSearch.Data.UrunTipi, UrunTipi, true) == 0)
                {
                    break;
                }
                    
                else if (String.Compare(tempSearch.Data.UrunTipi, UrunTipi, true) == 1)
                {
                    flag = true;
                    tempSearch = tempSearch.SolDugum;
                }
                    
                else if (String.Compare(tempSearch.Data.UrunTipi, UrunTipi, true) == -1)
                {
                    flag = true;
                    tempSearch = tempSearch.SagDugum;
                }
        
            }

            Kategori ktgr = new Kategori(UrunTipi);
            KategoriBSTDugum category = new KategoriBSTDugum(ktgr);
            kok = category;
            ktgr.Ekle(urun);

            if (tempSearch == null)
            {
                Kategori kategori = new Kategori(UrunTipi);
                kategori.Ekle(urun);
                if (flag)
                    tempParent.SolDugum = new KategoriBSTDugum(kategori);
                else
                    tempParent.SagDugum = new KategoriBSTDugum(kategori);
            }
            else
            {
                tempSearch.Data.Ekle(urun);
            }
        }

        public KategoriBSTDugum KategoriAra(KategoriBSTDugum dugum, string anahtar)
        {
            if (dugum == null)
                return null;
            else if (String.Compare(dugum.Data.UrunTipi, anahtar, true) == 0)
                return dugum;
            else if (String.Compare(dugum.Data.UrunTipi, anahtar, true) == 1)
                return KategoriAra(dugum.SolDugum, anahtar);
            else
                return KategoriAra(dugum.SolDugum, anahtar);
        }

        public Kategori DüsükDegerliUrun()
        {
            KategoriBSTDugum tempLeft = kok;
            while (tempLeft.SolDugum != null)
                tempLeft = tempLeft.SolDugum;

            return tempLeft.Data;

        }

        public Kategori YuksekDegerliUrun()
        {
            KategoriBSTDugum tempRight = kok;
            while (tempRight.SagDugum != null)
                tempRight = tempRight.SagDugum;

            return tempRight.Data;

        }

        public int Urunsayisi()
        {
            return Urunsayisi(kok);
        }
        public int Urunsayisi(KategoriBSTDugum node)
        {
            int count = 0;
            if (node != null)
            {
                count = 1;
                count += Urunsayisi(node.SolDugum);
                count += Urunsayisi(node.SagDugum);
            }
            return count;
        }
     
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(KategoriBSTDugum dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if (dugum.SolDugum == null && dugum.SagDugum == null)
                    count = 1;
                else
                    count = YaprakSayisi(dugum.SolDugum) + YaprakSayisi(dugum.SagDugum);
            }
            return count;
        }

        int duzeyCount = 0;
        int duzey = 1;
        private void Ziyaret(KategoriBSTDugum dugum)
        {
            duzeyCount++;
            int kalan = duzeyCount % 2;
            int bolum = duzeyCount / 2;
            if (kalan == 0 && bolum % 2 == 0)
                duzey += 1;
            liste.Add(new UrunListe() { duzey = duzey, urunler = dugum.Data.Urunler });
        }

        public List<UrunListe> Yazdir()
        {
            return liste;
        }
        public void PreOrder()
        {
            liste = new List<UrunListe>();
            duzeyCount = 0;
            PreOrderVisit(kok);
        }

        public void PreOrderVisit(KategoriBSTDugum dugum)
        {
            if (dugum == null)
                return;

            Ziyaret(dugum);
            PreOrderVisit(dugum.SolDugum);
            PreOrderVisit(dugum.SagDugum);
        }

        public void InOrder()
        {
            liste = new List<UrunListe>();
            duzeyCount = 0;
            InOrderVisit(kok);
        }

        public void InOrderVisit(KategoriBSTDugum dugum)
        {
            if (dugum == null)
                return;
            InOrderVisit(dugum.SolDugum);
            Ziyaret(dugum);
            InOrderVisit(dugum.SagDugum);
        }

        public void PostOrder()
        {
            liste = new List<UrunListe>();
            duzeyCount = 0;
            PostOrderVisit(kok);
        }

        public void PostOrderVisit(KategoriBSTDugum dugum)
        {
            if (dugum == null)
                return;
            PostOrderVisit(dugum.SolDugum);
            PostOrderVisit(dugum.SagDugum);
            Ziyaret(dugum);
        }
    }
}
