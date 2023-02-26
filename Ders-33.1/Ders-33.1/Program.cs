using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_33._1    // Metodla ekrana istenilen bilgiyi for dongusu icinde birden fazla yazdirma
{
    internal class Program
    {
        private static void yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }

        static void Main(string[] args)
        {

            Console.Write("Metni giriniz: ");
            string blg = Console.ReadLine();
            yazdir(blg);
            Console.Read();

        }
    }
}
