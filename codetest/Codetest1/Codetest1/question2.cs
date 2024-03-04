using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codetest1
{
    class question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string result = ExchangeFirstAndLastCharacters(input);

            Console.WriteLine("Result: " + result);
        }

        static string ExchangeFirstAndLastCharacters(string input)
        {
            if (input.Length < 2)
            {
                return input;
            }
            else
            {
                char[] charArray = input.ToCharArray();
                char firstChar = charArray[0];
                char lastChar = charArray[input.Length - 1];

                charArray[0] = lastChar;
                charArray[input.Length - 1] = firstChar;

                return new string(charArray);
            }
        }
    }
}
