using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CopyArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int len = int.Parse(Console.ReadLine());

            int[] a = new int[len];

            Console.WriteLine("Enter the elements of the array A:");
            for (int i = 0; i < len; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int[] b = new int[len];

            for (int i = 0; i < len; ++i)
            {
                b[i] = a[i];
            }

            Console.WriteLine("elements in the array B:");
            for (int i = 0; i < len; ++i)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
