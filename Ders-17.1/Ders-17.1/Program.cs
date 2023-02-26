using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_17._1
{   // Random komutuyla sehir atamasi yapma
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Sehir Atama Programi ***");

            Random rastgele = new Random();
            string[] sehirler = {"Adana", "Antalya" , "Izmir", "Denizli",
                                 "Istanbul", "Edirne", "Trabzon", "Samsun",
                                 "Ankara", "Konya", "Elazig", "Malatya",
                                 "Diyarbakir", "Sanliurfa" };
            int a;
            a = rastgele.Next(sehirler.Length);
            Console.WriteLine(a);
            Console.WriteLine(sehirler[a]);
            Console.ReadLine();
        }
    }
}
