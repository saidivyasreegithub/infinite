using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01
{
    class question8
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int len = marks.Length;

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < len; ++i)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            int avg, total = 0;
            int min = marks[0];
            int max = marks[0];
            for (int i = 0; i < len; ++i)
            {
                if (max < marks[i])
                {
                    max = marks[i];
                }
                if (min > marks[i])
                {
                    min = marks[i];
                }
                total += marks[i];
            }

            avg = total / len;
            Console.WriteLine($"Total value: {total}");
            Console.WriteLine($"Average value: {avg}");
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine("Marks in Ascending Order:");
            for (int i = 0; i < len; ++i)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("Marks in Descending Order:");
            for (int i = len - 1; i >= 0; --i)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
