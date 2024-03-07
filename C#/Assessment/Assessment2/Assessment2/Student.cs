using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    abstract class Student
    {
        public string studentName { get; set; }
        public int studentId { get; set; }
        public double studentGrade { get; set; }
        public abstract bool isPassed(double studentGrade);//abstract method
    }
    class Undergraduate : Student
    {

        public override bool isPassed(double studentGrade)
        {
            if (studentGrade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate : Student
    {
        public override bool isPassed(double studentGrade)
        {
            if (studentGrade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("enter student id:");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student grade");
            double studentGrade = double.Parse(Console.ReadLine());
            Undergraduate ug = new Undergraduate();
            ug.studentName = studentName;
            ug.studentId = studentId;
            ug.studentGrade = studentGrade;

            Graduate g = new Graduate();
            g.studentName = studentName;
            g.studentId = studentId;
            g.studentGrade = studentGrade;

            Console.WriteLine("Undergraduate student result:" + ug.isPassed(studentGrade));
            Console.WriteLine("graduate student result:" + g.isPassed(studentGrade));
            Console.Read();



        }
    }
   
}
