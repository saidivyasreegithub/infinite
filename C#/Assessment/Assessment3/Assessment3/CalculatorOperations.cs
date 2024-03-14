using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
   
    delegate int CalculatorOperation(int a, int b);

    class CalculatorOperationsa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            CalculatorOperation add = (a, b) => a + b;
            CalculatorOperation subtract = (a, b) => a - b;
            CalculatorOperation multiply = (a, b) => a * b;

            Console.WriteLine($"Addition: {add(num1, num2)}");
            Console.WriteLine($"Subtraction: {subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {multiply(num1, num2)}");

            Console.ReadKey();
        }
    }
}
