using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CONSOLE_VIDEO_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double phone;
            int op, age, workHour;
            string name, surname, email, city, country, companyName, department, workStatus;

            Console.WriteLine("___________________________________");
            Console.WriteLine("**** KEYVOLUTE DEVELOPMENT ****");
            Console.WriteLine("___________________________________");

            Console.WriteLine("1-Enter Personal Information");
            Console.Write("Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Surname: ");
            surname = Convert.ToString(Console.ReadLine());
            Console.Write("Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone Number: ");
            phone = Convert.ToDouble(Console.ReadLine());
            Console.Write("Email: ");
            email = Convert.ToString(Console.ReadLine());
            Console.Write("City: ");
            city = Convert.ToString(Console.ReadLine());
            Console.Write("Country: ");
            country = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("2-Enter Company Information");
            Console.Write("Company Name: ");
            companyName = Convert.ToString(Console.ReadLine());
            Console.Write("Department: ");
            department = Convert.ToString(Console.ReadLine());
            Console.Write("Work status:");
            workStatus = Convert.ToString(Console.ReadLine());
            Console.Write("Daily work Hour: ");
            workHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter your operation number:");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {

                case 1:
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("****  Your Personal information  ****");
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Surname: " + surname);
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine("Phone Number: " + phone);
                    Console.WriteLine("Email: " + email);
                    Console.WriteLine("City/Country: " + city + "/" + country);
                    Console.WriteLine("_____________________________________");
                    break;
                case 2:
                    Console.WriteLine("****  Your Company Information  ****");
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("Company Name: " + companyName);
                    Console.WriteLine("Department: " + department);
                    Console.WriteLine("Work Status: " + workStatus);
                    Console.WriteLine("Work Hours: " + workHour);
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("Enter your operation number again:");
                    op = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("You entered Invalid operation number");
                    break;
            }
        }    
    }
}
