using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_37   // Getter-Setter Metodu : Emlak Uygulamasi
{
    class Emlak
    {
        private string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }

        public string RENK
        {
            get { return renk; }
            set { renk = value.ToUpper(); }
        }

        public int ODASAYISI
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        public int KATNO
        {
            get { return katno; }
            set { katno = Math.Abs(value); }
        }

        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
