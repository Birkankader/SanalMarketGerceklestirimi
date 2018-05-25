using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class HashMap
    {
        int tabloBoyutu;
        HashList[] tablo;

        public HashMap(int boyut)
        {
            this.tabloBoyutu = boyut;
            tablo = new HashList[tabloBoyutu];
            for (int i = 0; i < tabloBoyutu; i++)
                tablo[i] = null;
        }

        private int HashFonksiyon(string anahtar)
        {
            int hashValue = 0;
            for (int i = 0; i < anahtar.Length; i++)
            {
                hashValue += anahtar[i];
            }
            return hashValue % tabloBoyutu;
        }

        public void Ekle(string anahtar, object deger)
        {
            int anahtarDeger = HashFonksiyon(anahtar);

            HashEntry temp = new HashEntry(anahtar, deger);

            if (tablo[anahtarDeger] == null)
            {
                tablo[anahtarDeger] = new HashList();
            }

            tablo[anahtarDeger].Ekle(temp);
        }
        public Urun Sil(string anahtar)
        {
            int anahtarDeger = HashFonksiyon(anahtar);

            if (tablo[anahtarDeger] == null)
                return null;

            HashEntry temp = tablo[anahtarDeger].Delete(anahtar);

            return (Urun)temp.Data;
        }

        public List<Urun> Ara(string anahtar)
        {
            int anahtarDeger = HashFonksiyon(anahtar);

            if (tablo[anahtarDeger] == null)
                return null;

            List<Urun> temp = tablo[anahtarDeger].Ara(anahtar);

            return temp;

        }

        public List<Urun> Listele()
        {
            List<Urun> liste = new List<Urun>();

            for (int i = 0; i < tablo.Length; i++)
            {
                if (tablo[i] == null)
                    continue;
                for (int j = 0; j < tablo[i].Hash.Count; j++)
                {
                    liste.Add((Urun)tablo[i].Hash[j].Data);
                }
            }
            return liste;
        }
    }
}
