using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the first number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the operations to be performed(+,-,*,/,%)");
            char op = Convert.ToChar(Console.ReadLine());
            int result;
            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine("{0} +{1}= {2}", n1, n2, result);
                    break;
                case '-':
                    result = n1 - n2;
                    Console.WriteLine("{0} - {1}= {2}", n1, n2, result);
                    break;
                case '*':
                    result = n1 * n2;
                    Console.WriteLine("{0} * {1}= {2}", n1, n2, result);
                    break;
                case '/':
                    result = n1 / n2;
                    Console.WriteLine("{0} / {1}={2}", n1, n2, result);
                    break;
                case '%':
                    result = n1 % n2;
                    Console.WriteLine("{0} % {1}={2}", n1, n2, result);
                    break;
                default:
                    Console.WriteLine("enter the valid operations(+,-,*,/,%)only");
                    break;


            }
        }
    }
}
