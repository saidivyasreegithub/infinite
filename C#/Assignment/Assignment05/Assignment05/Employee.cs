//Create an Employee class with Empid int, Empname string, Salary float.
//    Pass values to the members through Constructor.
//Create a derived class called ParttimeEmployee with Wages as a data member. 
//    Instantiate the base class through the derived class constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public double Salary { get; set; }

        public Employee(int empId, string empName, double salary)
        {
            Empid = empId;
            Empname = empName;
            Salary = salary;
        }

    }
    class ParttimeEmployee : Employee
    {
        public double Wages { get; set; }
        public ParttimeEmployee(int empId,string empName,double salary,double wages):base(empId,empName,salary)
        {
            Wages = wages;
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Employee Id:");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Employee Name:");
            string empName = Console.ReadLine();
            Console.WriteLine("enter the Employee Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Employee wages:");
            double wages = Convert.ToDouble(Console.ReadLine());


            ParttimeEmployee pt = new ParttimeEmployee(empId, empName, salary, wages);
            Console.WriteLine($"Employee Id:{pt.Empid},Employee Name:{pt.Empname},Employee Salary:{pt.Salary},Employee Wages:{pt.Wages}");
            Console.Read();

        }
    }
}
