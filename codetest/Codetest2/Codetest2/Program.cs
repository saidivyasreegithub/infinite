//1.Create an Abstract class called  Student with  Name, StudentId, Grade as members and also an abstract method
//boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  
 
//Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides
//Ispassed(grade) method

//For the UnderGrad class, if the grade is above 70.0, then isPassed returns true,
//otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true,
//otherwise returns false.
 
//Test the above by creating appropriate objects



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codetest2
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

    
           