using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class question7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < len; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int avg = 0;
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < len; ++i)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
                avg += arr[i];
            }
            avg = avg / 2;
            Console.WriteLine($"Average value: {avg}");
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");



        }
    }
}

  
