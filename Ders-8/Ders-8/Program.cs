using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_8    // IF ELSE ORNEKLERI - 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ornek 1 *****");
            string mevsim;
            Console.Write("Lutfen bir mevsim giriniz: ");
            mevsim = Console.ReadLine();

            if (mevsim == "kis")
            {
                Console.WriteLine("Kis mevsimi aylari: Aralik - Ocak - Subat");
            }
            else if(mevsim == "ilkbahar")
            {
                Console.WriteLine("Ilkbahar mevsimi aylari: Mart - Nisan - Mayis");
            }
            else if(mevsim == "yaz")
            {
                Console.WriteLine("Yaz mevsimi aylari: Haziran - Temmuz - Agustos");
            }
            else if(mevsim == "sonbahar")
            {
                Console.WriteLine("Sonbahar mevsimi aylari: Eylul - Ekim - Kasim");
            }


            Console.WriteLine("******** Ornek 2 ********");
            Console.WriteLine("*** Kirtasiye Dukkani ***");
            double x, indirim, odemeMiktari;
            Console.Write("Alisveris tutarini giriniz: ");
            x = Convert.ToDouble(Console.ReadLine());
            if(x < 100)
            {
                indirim = x * 10 / 100;
                odemeMiktari = x - indirim;
                Console.WriteLine("Toplam odemeniz gereken miktar: " + odemeMiktari);
                Console.WriteLine();
            }
            else if(x >=100 && x <= 150)
            {
                indirim = x * 15 / 100;
                odemeMiktari = x - indirim;
                Console.WriteLine("Toplam odemeniz gereken miktar: " + odemeMiktari);
                Console.WriteLine();
            }
            else if (x >= 150 && x <= 200)
            {
                indirim = x * 20 / 100;
                odemeMiktari = x - indirim;
                Console.WriteLine("Toplam odemeniz gereken miktar: " + odemeMiktari);
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
