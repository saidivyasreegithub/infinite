using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class question5
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter the two numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int result = sumTriple(n1, n2);
            Console.WriteLine($"result:{result}");

        }
        public static int sumTriple(int n1, int n2)
        {
            return n1 == n2 ? (n1 + n2) * 3 : n1 + n2;
        }
    }
}
