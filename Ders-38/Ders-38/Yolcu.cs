using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_38
{
    public class Yolcu
    {
        private string ad;
        private string soyad;
        private string cinsiyet;
        private int yas;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToLower(); }
        }

        public string CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToUpper(); }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

    }
}
