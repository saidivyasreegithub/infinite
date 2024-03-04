using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class question6
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a day number");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("enter the valided day number");
                    break;






            }
        }
    }
}
