using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_12_Faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Faktoriyeli alinacak sayiyi girin:");
            sayi = Convert.ToInt16(Console.ReadLine());
            int faktoriyel = 1;

            while (sayi > 1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            Console.WriteLine(faktoriyel);
            Console.ReadLine();
        }
    }
}
