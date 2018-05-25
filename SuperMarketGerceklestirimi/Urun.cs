using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public string Marka { get; set; }
        public string Aciklama { get; set; }
        public string UrunTipi { get; set; }
        public string Model { get; set; }
        public int Miktar { get; set; }
        public decimal Maliyet { get; set; }
        public decimal Fiyat { get; set; }

    }
}
