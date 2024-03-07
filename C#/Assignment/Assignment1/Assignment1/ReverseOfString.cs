using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ReverseOfString
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the string: ");
            String s = Console.ReadLine();
            String st = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                st += s[i];
            }
            Console.WriteLine($"Reverse String is: {st}");
        }
    }
}
