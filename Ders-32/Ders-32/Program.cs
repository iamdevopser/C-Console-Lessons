using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_32   // Metod cagirma
{
    internal class Program
    {
        private static void veriler()
        {
            Console.WriteLine("Mudur: A ");
            Console.WriteLine("Ogretmen: B ");
            Console.WriteLine("Okul: C");
            Console.WriteLine("Egitsel Kol: D");
            Console.WriteLine("Sehir: E");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        static void Main(string[] args)
        {
            veriler();
            Console.Read();
        }
    }
}
