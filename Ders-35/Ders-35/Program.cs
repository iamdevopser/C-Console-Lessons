using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_35   // Cars sinifinda olusturulan metodlari main class ta obje ile cagirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars();

            car1.color = "Black";
            car1.price = 150000;
            car1.model = "2016";
            car1.transmission = "Automatic";
            car1.plate = "45-TZ-46";

            Console.WriteLine("Car's color: " + car1.color);
            Console.WriteLine("Car's price: " + car1.price);
            Console.WriteLine("Car's model year: " + car1.model);
            Console.WriteLine("Car's transmission: " + car1.transmission);
            Console.WriteLine("Car's plate: " + car1.plate);


            Console.Read();
        }
    }
}
