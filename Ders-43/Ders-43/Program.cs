using System;
using System.Text;
using System.Threading;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Ders_43   // Sayi tahmin oyunu

{
    class Program
    {
        static void Main(string[] args)
        {

            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele = new Random();
            hafiza = rastgele.Next(1, 100);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.WriteLine("sayi girin:");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha kucuk sayi girin.");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha buyuk sayi girin.");
                }

            }
            Console.WriteLine("Tebriklerrrrrrr......");
            Console.WriteLine("{0}.denemede buldunuz.", sayac);
            Console.Read();


        }
    }
}

