using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiSimulasyonu
{
    public class Takimlar
    {
        public string TakimAdi { get; set; }
        public string Ulke { get; set; }
        public string Torba { get; set; }
        public string Grup { get; set; }
        public string Rakip1 { get; set; }
        public string Rakip2 { get; set; }
        public string Rakip3 { get; set; }
        public int AtilanGol { get; set; }
        public int YenilenGol { get; set; }
        public int Avaraj {
            get
            {
                return AtilanGol - YenilenGol;
            }
        }
        public int Puan { get; set; }

    }


}
