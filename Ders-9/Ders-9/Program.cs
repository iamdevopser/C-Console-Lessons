
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9    // SWITCH UYGULAMALARI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********  ORNEK 1 ***********");
            Console.Write("1-7 arasinda bir sayi giriniz: ");
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1: 
                    Console.Write("Gun : Pazartesi");
                    break;
                case 2: 
                    Console.Write("Gun : Sali");
                    break;
                case 3:
                    Console.Write("Gun : Carsamba");
                    break;
                case 4:
                    Console.Write("Gun : Persembe");
                    break;
                case 5:
                    Console.Write("Gun : Cuma");
                    break;
                case 6:
                    Console.Write("Gun : Cumartesi");
                    break;
                case 7:
                    Console.Write("Gun : Pazar");
                    break;
            }

            Console.WriteLine("********  ORNEK 2 ***********");
            string mevsim;
            Console.WriteLine("Lutfen bir mevsim ismini kcuk harflerle giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kis":
                    Console.WriteLine("Kis mevsimi aylari: Aralik, Ocak, Subat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Ilkbahar mevsimi aylari: Mart, Nisan, Mayis");
                    break;
                case "yaz":
                    Console.WriteLine("Kis mevsimi aylari: Haziran, Temmuz, Agustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Kis mevsimi aylari: Eylul, Ekim, Kasim");
                    break;
                default: Console.WriteLine("Hatali mevsim girisi yaptiniz.");
                    break;
            }

            Console.WriteLine("********  ORNEK 3 ***********");
            string sehir;
            sehir = Console.ReadLine();

            switch (sehir)
            {
                case "adana":
                    Console.WriteLine("Istanbul'un Adana'ya uzakligi 939 km dir.");
                    break;
                case "ankara":
                    Console.WriteLine("Istanbul'un Ankara'ya uzakligi 453 km dir.");
                    break;
                case "antalya":
                    Console.WriteLine("Istanbul'un Antalya'ya uzakligi 724 km dir.");
                    break;
                case "bursa":
                    Console.WriteLine("Istanbul'un Bursa'ya uzakligi 243 km dir.");
                    break;
                case "elazig":
                    Console.WriteLine("Istanbul'un Elazig'a uzakligi 1212 km dir.");
                    break;
                case "izmir":
                    Console.WriteLine("Istanbul'un Izmir'e uzakligi 561 km dir.");
                    break;
                case "malatya":
                    Console.WriteLine("Istanbul'un Malatya'ya uzakligi 1114 km dir.");
                    break;
                case "trabzon":
                    Console.WriteLine("Istanbul'un Trabzon'a uzakligi 1070 km dir.");
                    break;
                default: Console.WriteLine("Yanlis sehir adi girdiniz.");
                    break;
            }



            Console.ReadLine();
        }
    }
}
