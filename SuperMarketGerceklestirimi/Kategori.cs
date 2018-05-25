using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class Kategori
    {
        public string UrunTipi { get; set; }
        public List<Urun> Urunler { get; set; }

        public Kategori(string UrunTipi)
        {
            this.UrunTipi = UrunTipi;
            Urunler = new List<Urun>();
        }

        public void Ekle(Urun urun)
        {
            Urunler.Add(urun);
        }
    }
}
