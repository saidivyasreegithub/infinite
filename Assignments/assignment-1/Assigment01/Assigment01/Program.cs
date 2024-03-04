using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            if (n1 == n2)
                Console.WriteLine("{0} and {1} are equal.\n", n1, n2);
            else
            {
                Console.WriteLine("{0} and {1} are not equal.\n", n1, n2);
            }

        }

    }
}
