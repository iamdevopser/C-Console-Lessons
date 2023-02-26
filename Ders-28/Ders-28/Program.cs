using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZAMAN FONKSIYONLARI

            DateTime time;
            time = DateTime.Now;
            int month = time.Month;
            int day = time.Day;
            int year = time.Year;
            DayOfWeek dayOfWeek = time.DayOfWeek;

            Console.WriteLine("*** C# dersleri Tarih Saat Fonksiyonlari ***");
            Console.WriteLine("{0:d}", time); // 2/8/202
            Console.WriteLine("{0:D}", time); // Wednesday, February 8, 2023
            Console.WriteLine("{0:f}", time); // Wednesday, February 8, 2023 9:20 AM
            Console.WriteLine("{0:F}", time); // Wednesday, February 8, 2023 9:21:22 AM
            Console.WriteLine("{0:g}", time); // 2 / 8 / 2023 9:23 AM
            Console.WriteLine("{0:G}", time); // 2/8/2023 9:24:12 AM
            Console.WriteLine("{0:r}", time); // Wed, 08 Feb 2023 09:25:52 GMT
            Console.WriteLine("{0:m}", time); // February 8
            Console.WriteLine("{0:s}", time);  // 2023 - 02 - 08T09: 29:40
            Console.WriteLine("{0:t}", time); // 9:29 AM
            Console.WriteLine("{0:T}", time); // 9:29:40 AM
            Console.WriteLine("{0:Y}", time); // February 2023
            Console.WriteLine("Day:{0} ", day);
            Console.WriteLine("Month:{0} ", month);
            Console.WriteLine("Year:{0} ", year);
            Console.WriteLine("Day of week: {0}", dayOfWeek);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
