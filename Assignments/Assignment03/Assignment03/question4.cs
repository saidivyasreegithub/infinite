using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
 
class Scholarship
    {
        public void Merit(int marks, double fees)
        {
            double scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3 * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5 * fees;
            }

            Console.WriteLine($"Scholarship Amount: {scholarshipAmount}");
        }
    }

    class question4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter marks:");
                int marks = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter fees:");
                double fees = double.Parse(Console.ReadLine());

                Scholarship scholarship = new Scholarship();
                scholarship.Merit(marks, fees);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid marks and fees.");
            }
            Console.Read();
        }
    }
}

