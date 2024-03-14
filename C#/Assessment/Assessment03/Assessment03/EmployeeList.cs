using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment03
{

  class EmployeeList

  {

            public int EmpId { get; set; }

            public string EmpFirstName { get; set; }

            public string EmpLastName { get; set; }

            public string EmpTitle { get; set; }

            public DateTime EmpDob { get; set; }

            public DateTime EmpDoj { get; set; }

            public string EmpCity { get; set; }

  }

        class Solution

        {

            static void Main(string[] args)

            {

                List<EmployeeList> el = new List<EmployeeList>

            {

                new EmployeeList { EmpId = 1001, EmpFirstName = "Malcolm", EmpLastName = "Daruwalla", EmpTitle = "Manager", EmpDob = new DateTime(1984,11,16), EmpDoj = new DateTime(2011, 6, 8), EmpCity = "Mumbai" },

                new EmployeeList { EmpId = 1002, EmpFirstName = "Asdin", EmpLastName = "Dhalla", EmpTitle = "AsstManager", EmpDob = new DateTime(1984, 08, 20), EmpDoj = new DateTime(2012, 07, 07), EmpCity = "Mumbai" },

                new EmployeeList { EmpId = 1003, EmpFirstName = "Madhavi", EmpLastName = "Oza", EmpTitle = "Consultant", EmpDob = new DateTime(1987, 11, 14), EmpDoj = new DateTime(2015, 04, 12), EmpCity = "Pune" },

                new EmployeeList { EmpId = 1004, EmpFirstName = "Saba", EmpLastName = "Shaikh", EmpTitle = "SeniorEngineer", EmpDob = new DateTime(1990, 06, 03), EmpDoj = new DateTime(2016, 02, 02), EmpCity = "Pune" },

                new EmployeeList { EmpId = 1005, EmpFirstName = "Nazia", EmpLastName = "Shaikh", EmpTitle = "SeniorEngineer", EmpDob = new DateTime(1991, 03, 08), EmpDoj = new DateTime(2016, 02, 02), EmpCity = "Mumbai" },

                new EmployeeList { EmpId = 1006, EmpFirstName = "Amit", EmpLastName = "Pathak", EmpTitle = "Consultant", EmpDob = new DateTime(1989, 11, 07), EmpDoj = new DateTime(2014, 08, 08), EmpCity = "Chennai" },

                new EmployeeList { EmpId = 1007, EmpFirstName = "Vijay", EmpLastName = "Natrajan", EmpTitle = "Consultant", EmpDob = new DateTime(1989, 12, 02), EmpDoj = new DateTime(2015, 06, 01), EmpCity = "Mumbai" },

                new EmployeeList { EmpId = 1008, EmpFirstName = "Rahul", EmpLastName = "Dubey", EmpTitle = "Associate", EmpDob = new DateTime(1993, 11, 11), EmpDoj = new DateTime(2014, 11, 06), EmpCity = "Chennai" },

                new EmployeeList { EmpId = 1009, EmpFirstName = "Suresh", EmpLastName = "Mistry", EmpTitle = "Associate", EmpDob = new DateTime(1992, 08, 12), EmpDoj = new DateTime(2014, 12, 03), EmpCity = "Chennai" },

                new EmployeeList { EmpId = 1010, EmpFirstName = "Sumit", EmpLastName = "Shah", EmpTitle = "Manager", EmpDob = new DateTime(1991, 04, 12), EmpDoj = new DateTime(2016, 01, 02), EmpCity = "Pune" },

            };

                //1.Displaying all the Employee Details

                Console.WriteLine("Details of all employees:");

                foreach (var emp in el)

                {

                    Console.WriteLine($"{emp.EmpId} - {emp.EmpFirstName} {emp.EmpLastName}, {emp.EmpTitle}, DOB: {emp.EmpDob.ToShortDateString()}, DOJ: {emp.EmpDob.ToShortDateString()}, City: {emp.EmpCity}");

                }

                Console.WriteLine();

                //2.Displaying details of all the employees whose location is not Mumbai

                var notMumbaiEmployees = el.Where(emp => emp.EmpCity != "Mumbai");

                Console.WriteLine("Details of employees whose location is not Mumbai:");

                foreach (var emp in notMumbaiEmployees)

                {

                    Console.WriteLine($"{emp.EmpId} - {emp.EmpFirstName} {emp.EmpLastName}, {emp.EmpTitle}, DOB: {emp.EmpDob.ToShortDateString()}, DOJ: {emp.EmpDob.ToShortDateString()}, City: {emp.EmpCity}");

                }

                Console.WriteLine();

                //3.Displaying  details of all the employees whose title is AsstManager

                var asstManagers = el.Where(emp => emp.EmpTitle == "AsstManager");

                Console.WriteLine("Details of employees whose title is AsstManager:");

                foreach (var emp in asstManagers)

                {

                    Console.WriteLine($"{emp.EmpId} - {emp.EmpFirstName} {emp.EmpLastName}, {emp.EmpTitle}, DOB: {emp.EmpDob.ToShortDateString()}, DOJ: {emp.EmpDob.ToShortDateString()}, City: {emp.EmpCity}");

                }

                Console.WriteLine();

                //4. Display details of all the employees whose Last Name start with S

                var lastNameStartsWithS = el.Where(emp => emp.EmpLastName.StartsWith("S"));

                Console.WriteLine("Details of employees whose Last Name starts with S:");

                foreach (var emp in lastNameStartsWithS)

                {

                    Console.WriteLine($"{emp.EmpId} - {emp.EmpFirstName} {emp.EmpLastName}, {emp.EmpTitle}, DOB: {emp.EmpDob.ToShortDateString()}, DOJ: {emp.EmpDob.ToShortDateString()}, City: {emp.EmpCity}");

                }

                Console.ReadKey();

            }

        }

}

  
