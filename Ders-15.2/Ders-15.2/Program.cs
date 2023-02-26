using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_15._2
{   // Dizideki cift sayilari bulma
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rakamlar = { 1, 7, 5, 4, 8, 6, 9, 3 };

            foreach (int sayi in rakamlar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }


            Console.ReadLine();
        }
    }
}
