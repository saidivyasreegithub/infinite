using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
            };
            // 1.Display a list of all the employee who have joined before 1 / 1 / 2015
            var EmployeeJoined = empList.Where(e => e.DOJ < new DateTime(2015,1,1));
            foreach(var emp in EmployeeJoined)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            var empdateofbirth = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            foreach(var e in empdateofbirth)
            {
                Console.WriteLine($"{e.FirstName}{e.LastName}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            //3.Display a list of all the employee whose designation is Consultant and Associate
            var desg = empList.Where(emp => emp.Title.Equals ("Consultant" )|| emp.Title.Equals("Associate"));
            foreach(var e in desg)
            {
                Console.WriteLine($"{e.FirstName}{e.LastName}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            //4.Display total number of employees
            var empcount = empList.Count();
            Console.WriteLine($"Total Number of Employees:{empcount}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            //5.Display total number of employees belonging to “Chennai”
            int empBelongChennai = empList.Count(e=>e.City.Equals("Chennai"));
                Console.WriteLine($"Total Number of Employees:{empBelongChennai}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            //6.Display highest employee id from the list
            int highestEmployeeId = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest employee ID: {highestEmployeeId}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            //7.Display total number of employee who have joined after 1 / 1 / 2015
            var EmpJoinedAfter = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Total Number of Employees Joined After 01-01-2015:{EmpJoinedAfter}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            //8.Display total number of employee whose designation is not “Associate”
            var empdesg = empList.Count(e => e.Title != "Associate");
            Console.WriteLine("\nTotal number of employees whose designation is not Associate: " + empdesg);
            var notAssEmp = empList.Where(x => x.Title != "Associate");
            foreach (var v in notAssEmp)
                Console.WriteLine(v.FirstName + " " + v.LastName + " ->" + v.Title);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            //9.Display total number of employee based on City
            var employeesByCity = empList.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() });
            Console.WriteLine("Total number of employees based on City:");
            foreach (var group in employeesByCity)
            {
                Console.WriteLine($"{group.City}: {group.Count}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            //10.Display total number of employee based on city and title
            var employeesByCityAndTitle = empList.GroupBy(e => new { e.City, e.Title }).Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
            Console.WriteLine("Total number of employees based on City and Title:");
            foreach (var group in employeesByCityAndTitle)
            {
                Console.WriteLine($"{group.City} - {group.Title}: {group.Count}");
            }
            Console.WriteLine("-----------------------------------------");
            //11.Display total number of employee who is youngest in the list
            var youngestEmployee = empList.OrderBy(e => e.DOB).First();
            Console.WriteLine($"Youngest employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}");
            Console.Read();
        }
    }
}