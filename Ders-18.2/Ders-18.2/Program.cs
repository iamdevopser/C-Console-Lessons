using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_18._2        // Cinsiyet belirleme
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Sehir Atama Programi ***");
            char cinsiyet;
            Console.WriteLine("Cinsiyeti girin:");
            cinsiyet = Convert.ToChar(Console.ReadLine());
            if (cinsiyet == 'e' || cinsiyet == 'E')
            {
                Console.WriteLine("Cinsiyet: Erkek");
            }
            else if (cinsiyet == 'k' || cinsiyet == 'K')
            {
                Console.WriteLine("Cinsiyet: Kadin");
            }
            else Console.WriteLine("Cinsiyet Belirsiz");

            Console.ReadLine();
        }
    }
}
