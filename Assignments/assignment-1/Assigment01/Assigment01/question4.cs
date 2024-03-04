using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class question4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the input number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} =  {num * i}");
            }
        }
    }
}
