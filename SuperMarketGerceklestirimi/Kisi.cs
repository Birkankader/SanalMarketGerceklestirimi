using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public bool Kontrol(string KullaniciAdi, string Sifre)
        {
            if (this.KullaniciAdi == KullaniciAdi && this.Sifre == Sifre)
                return true;
            return false;
        }
    }
}
