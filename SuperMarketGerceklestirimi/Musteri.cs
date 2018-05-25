using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class Musteri:Kisi
    {
        public SuperMarket Market { get; set; }
        public List<Urun> AlisverisListesi { get; set; }

        public Musteri()
        {
            AlisverisListesi = new List<Urun>();
        }
        public Urun UrunVarmi(string Aciklama)
        {
            Urun urun = null;

            foreach (var item in AlisverisListesi)
            {
                if (item.Aciklama == Aciklama)
                {
                    urun = item;
                    break;
                }
            }

            return urun;
        }
        public void Ekle(Urun u)
        {
            Urun urun = UrunVarmi(u.Aciklama);
            if (urun != null)
                return;
            AlisverisListesi.Add(urun);
        }

        public void HepsiniAl()
        {
            while (AlisverisListesi.Count != 0)
            {
                AlisverisListesi[0].Miktar--;
                AlisverisListesi.RemoveAt(0);
            }
        }

        public bool UrunAl(string Aciklama)
        {
            Urun urun = UrunVarmi(Aciklama);
            if (urun == null)
                return false;
            urun.Miktar--;
            AlisverisListesi.Remove(urun);
            return true;

        }

        public bool UrunSil(string Aciklama)
        {
            foreach (var item in AlisverisListesi)
            {
                if (item.Aciklama == Aciklama)
                {
                    AlisverisListesi.Remove(item);
                    return true;
                }
            }

            return false;
        }
    }
}
