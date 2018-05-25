using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class HashList
    {
        public List<HashEntry> Hash { get; set; }

        public HashList()
        {
            Hash = new List<HashEntry>();
        }

        public void Ekle(HashEntry hashEntry)
        {
            Hash.Add(hashEntry);
        }

        public HashEntry Delete(string key)
        {
            for (int i = 0; i < Hash.Count; i++)
            {
                if (Hash[i].Anahtar == key)
                {
                    HashEntry temp = Hash[i];
                    Hash.RemoveAt(i);
                    return temp;
                }
            }
            return null;
        }

        public List<Urun> Ara(string anahtar)
        {
            List<Urun> list = new List<Urun>();
            for (int i = 0; i < Hash.Count; i++)
            {
                if (Hash[i].Anahtar == anahtar)
                {
                    list.Add((Urun)Hash[i].Data);
                }
            }
            return list;
        }
    }
}
