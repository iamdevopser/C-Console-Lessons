using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_45
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random();
            Console.WriteLine("Rastgele Lig Turnuvamiza Hosgeldiniz...\n");
            Console.WriteLine("Katilan tum takimlar C# Dersleri olarak basarilar dileriz...\n");

            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int gs1 = 0;
            int fb1 = 0;
            int bjk1 = 0;
            int ts1 = 0;
            int gs2 = 0;
            int fb2 = 0;
            int bjk2 = 0;
            int ts2 = 0;
            int gs3 = 0;
            int fb3 = 0;
            int bjk3 = 0;
            int ts3 = 0;
            int gsSon, fbSon, bjkSon, tsSon;

            int sayac = 1;
            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            a1 = rastgele.Next(0, 6);
            b1 = rastgele.Next(0, 6);
            c1 = rastgele.Next(0, 6);
            d1 = rastgele.Next(0, 6);

            a2 = rastgele.Next(0, 6);
            b2 = rastgele.Next(0, 6);
            c2 = rastgele.Next(0, 6);
            d2 = rastgele.Next(0, 6);

            a3 = rastgele.Next(0, 6);
            b3 = rastgele.Next(0, 6);
            c3 = rastgele.Next(0, 6);
            d3 = rastgele.Next(0, 6);

            if (sayac == 1)
            {

                Console.WriteLine("1.Hafta skorlari:");
                Console.WriteLine("_________________");
                Console.WriteLine("Galatasaray " + a1 + "-" + b1 + " Fenerbahce");
                Console.WriteLine("Besiktas " + c1 + "-" + d1 + " Trabzonspor\n");
                if (a1 > b1)
                {
                    gs1 = gs + 3;
                }
                if (a1 < b1)
                {
                    fb1 = fb + 3;
                }
                if (a1 == b1)
                {
                    gs1 = gs + 1;
                    fb1 = fb + 1;
                }
                if (c1 > d1)
                {
                    bjk1 = bjk + 3;
                }
                if (c1 < d1)
                {
                    ts1 = ts + 3;
                }
                if (c1 == d1)
                {
                    bjk1 = bjk + 1;
                    ts1 = ts + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 2)
            {

                Console.WriteLine("2.Hafta skorlari:");
                Console.WriteLine("_________________");
                Console.WriteLine("Fenerbahce " + b2 + "-" + c2 + " Besiktas");
                Console.WriteLine("Galatasaray " + a2 + "-" + d2 + " Trabzonspor\n");
                if (a2 > d2)
                {
                    gs2 = gs + 3;
                }
                if (a2 < d2)
                {
                    ts2 = ts + 3;
                }
                if (a2 == d2)
                {
                    gs2 = gs + 1;
                    ts2 = ts + 1;
                }
                if (b2 > c2)
                {
                    fb2 = fb + 3;
                }
                if (b2 < c2)
                {
                    bjk2 = bjk + 3;
                }
                if (b2 == c2)
                {
                    fb2 = fb + 1;
                    bjk2 = bjk + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 3)
            {

                Console.WriteLine("3.Hafta skorlari:");
                Console.WriteLine("_________________");
                Console.WriteLine("Fenerbahce " + b3 + "-" + d3 + " Trabzonspor");
                Console.WriteLine("Galatasaray " + a3 + "-" + c3 + " Besiktas\n");
                if (a3 > c3)
                {
                    gs3 = gs + 3;
                }
                if (a3 < c3)
                {
                    bjk3 = bjk + 3;
                }
                if (a3 == b3)
                {
                    gs3 = gs + 1;
                    bjk3 = bjk + 1;
                }
                if (b3 > d3)
                {
                    fb3 = fb + 3;
                }
                if (b3 < d3)
                {
                    ts3 = ts + 3;
                }
                if (b3 == d3)
                {
                    fb3 = fb + 1;
                    ts3 = ts + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            gsSon = gs1 + gs2 + gs3;
            fbSon = fb1 + fb2 + fb3;
            bjkSon = bjk1 + bjk2 + bjk3;
            tsSon = ts1 + ts2 + ts3;

            Console.WriteLine("**** SCORE Tablosu ***");
            Console.WriteLine("Galatasaray: " + gsSon + "\nFenerbahce : " + fbSon + "\nBesiktas   : " + bjkSon + "\nTrabzonspor: " + tsSon);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
