using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak eml = new Emlak();

            eml.SEMT = "Chisinau";
            eml.RENK = "Mavi";
            eml.ODASAYISI = 4;
            eml.KATNO = 8;
            eml.ALAN = 80;

            Console.WriteLine("Semt: " + eml.SEMT);
            Console.WriteLine("Oda Rengi: " + eml.RENK);
            Console.WriteLine("Oda Sayisi: " + eml.ODASAYISI);
            Console.WriteLine("Kat No: " + eml.KATNO);
            Console.WriteLine("Toplam Alan: " + eml.ALAN);
            Console.Read();
        }
    }
}
