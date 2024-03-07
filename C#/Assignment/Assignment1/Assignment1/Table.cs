using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Table
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
