using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1

{
    class Largest

    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the n1 and n2,n3 values");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int res = question3(n1, n2, n3);
            Console.WriteLine($"the largest number is:{res}");
        }
        public static int question3(int n1,int n2,int n3)
        {
            if (n1 > n2 && n1 > n3 )
            {
                return n1;
            }
            else if (n2>n3)
            {
                return n2;

            }
            else
            {
                return n3;
            }
        }
    }
}
