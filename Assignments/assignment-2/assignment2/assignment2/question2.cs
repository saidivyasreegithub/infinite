//Create a class called student which has data members like rollno, name, class, Semester, branch, int[] marks = new int marks [5](marks of 5 subjects )

//-Pass the details of student like rollno, name, class, SEM, branch in constructor

//- For marks write a method called GetMarks() and give marks for all 5 subjects

//-Write a method called displayresult, which should calculate the average marks

//-If marks of any one subject is less than 35 print result as failed
//-If marks of all subject is >35, but average is < 50 then also print result as failed
//-If avg > 50 then print result as passed.

//-Write a DisplayData() method to display all values.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Student
    {
        private int rollNo;
        private string name;
        private string Class;

        private string sem;
        private string branch;
        private int[] marks = new int[5];


        public  Student(int rollNo, string name, string Class, string sem, string branch)
        {
            rollNo = rollNo;
           name = name;
           Class = Class;
            sem = sem;
            branch = branch;
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

            if (marks[0] < 35 || marks[1] < 35 || marks[2] < 35 || marks[3] < 35 || marks[4] < 35)
            {
                Console.WriteLine($"Result is failed");
            }
            else if (marks[0] > 35 && average < 50 || marks[1] > 35 && average < 50 || marks[2] > 35 && average < 50 || marks[3] > 35 && average < 50 || marks[4] > 35 && average < 50)
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
            Console.WriteLine($"Roll No:{rollNo}");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"class:{Class}");
            Console.WriteLine($"Semeter:{sem}");
            Console.WriteLine($"Branch:{branch}");
            Console.WriteLine("Marks");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject{i + 1}:{marks[i]}");
            }

        }
    }
    class question2
    {
        static void Main(String[] args)
        {
            
            Student student = new Student(123, "divya", "btech", "1sem", "ece");
            int[] Marks = { 78, 98, 90, 45, 50 };
            student.GetMarks(Marks);
            student.DisplayResult();
            student.DisplayData();

        }
    }
}

      
      