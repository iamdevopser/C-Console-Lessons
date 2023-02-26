using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11 
    // Konsoldan girilen sayi tek olasiye kadar while dongusu icinde sayi girilir.
    // Sayi tek girildiginde ekrana tek sayi oldugu yazdirilir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi;
            Console.WriteLine("Bir sayi girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi % 2 == 0)
            {
                Console.WriteLine("Bir sayi girin:");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tek sayi girdiniz.");
            Console.ReadLine();
        }
    }
}
