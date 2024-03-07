using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        private int RollNo;
        private string Name;
        private string Class;

        private string Sem;
        private string Branch;
        private int[] marks = new int[5];


        public Student(int RollNo, string Name, string Class, string Sem, string Branch)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Class = Class;
            this.Sem = Sem;
            this.Branch = Branch;
        }
        public void GetMarks(int[] subMarks)
        {
            if (subMarks.Length != 5)
            {
                Console.WriteLine("please enter the valid number of subjects: ");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    marks[i] = subMarks[i];
                }
            }

        }
        public void DisplayResult()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = marks[i] + sum;
            }
            double average = (double)sum / 5;
            Console.WriteLine($"the average of the total marks is:" + average);

            if (marks[0] < 39 || marks[1] < 39 || marks[2] < 39 || marks[3] < 39 || marks[4] < 39)
            {
                Console.WriteLine($"Result is failed");
            }
            else if (marks[0] > 39 && average < 50 || marks[1] > 39 && average < 50 || marks[2] > 39 && average < 50 || marks[3] > 39 && average < 50 || marks[4] > 39 && average < 50)
            {
                Console.WriteLine($"Result is failed");
            }
            else
            {
                Console.WriteLine($"Result is passed");
            }
        }
        public void DisplayData()
        {
            Console.WriteLine($"Roll No:{RollNo}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"class:{Class}");
            Console.WriteLine($"Semeter:{Sem}");
            Console.WriteLine($"Branch:{Branch}");
            Console.WriteLine("Marks");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject{i + 1}:{marks[i]}");
                Console.Read();
            }

        }
    }
    class question2
    {
        static void Main(String[] args)
        {
            Student student = new Student(123, "divya", "Btech", "1sem", "ECE");
            int[] Marks = { 78, 98, 90, 45, 50 };
            student.GetMarks(Marks);
            student.DisplayResult();
            student.DisplayData();

        }
    }
}
