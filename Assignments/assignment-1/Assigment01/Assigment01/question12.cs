using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class question12
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 1st the string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd the string: ");
            string s2 = Console.ReadLine();

            if (s1.Equals(s2))
            {
                Console.WriteLine("String 1 and String 2 are equals");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
