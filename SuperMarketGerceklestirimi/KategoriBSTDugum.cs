using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGerceklestirimi
{
    public class KategoriBSTDugum
    {
        public KategoriBSTDugum SolDugum;
        public KategoriBSTDugum SagDugum;
        public Kategori Data;
        public KategoriBSTDugum()
        {
            SolDugum = null;
            SagDugum = null;
            this.Data = null;
        }
        public KategoriBSTDugum(Kategori Data)
        {
            SolDugum = null;
            SagDugum = null;
            this.Data = Data;
        }

    }
}
