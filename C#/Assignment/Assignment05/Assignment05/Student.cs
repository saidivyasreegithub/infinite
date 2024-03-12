//4.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. 
//    Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string StudentName { get; set; }

        void ShowDetails();
    }
   public class DayScholar:IStudent
   {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            
        public void ShowDetails()
        {
            Console.WriteLine($"Student Id:{StudentId},Student Name:{StudentName}");

        }         
        
   }
    public class Resident:IStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Student Id:{StudentId},Student Name:{StudentName}");

        }
    }
    class Solution1
    {
        static void Main(string[] args)
        {
            DayScholar ds = new DayScholar();
            Console.WriteLine("enter the student Id:");
            ds.StudentId= int.Parse(Console.ReadLine());

            Console.WriteLine($"enter the Student Name:");
         ds.StudentName = Console.ReadLine();


            Resident r = new Resident();
            Console.WriteLine("enter the student Id:");
            r.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter the Student Name:");
            r.StudentName = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Student Details");
            ds.ShowDetails();
            r.ShowDetails();

            Console.Read();
        }
    }

}
