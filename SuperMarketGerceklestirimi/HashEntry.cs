using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class HashEntry
    {
        public string Anahtar { get; set; }
        public object Data { get; set; }

        public HashEntry(string anahtar, object data)
        {
            this.Anahtar = anahtar;
            this.Data = data;
        }
    }
}
