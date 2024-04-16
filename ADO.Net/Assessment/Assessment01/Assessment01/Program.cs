using System;
using System.Data;
using System.Data.SqlClient;

namespace Assessment01
{
    class Program
    {
        public static SqlConnection con = null;
        static void Main(string[] args)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee gender (M/F): ");
            string gender = Console.ReadLine();

            Console.Write("Enter employee salary: ");
            decimal salary = decimal.Parse(Console.ReadLine()); // Read the salary from the user

            // Call the InsertEmployee stored procedure and display the returned EmpId and Salary
            int empId;
            decimal deductedSalary = ExecuteInsertEmployee( name, gender, salary, out empId);

            // Display the retrieved EmpId and Deducted Salary
            Console.WriteLine($"Employee inserted with EmpId: {empId} and Salary after deduction: {deductedSalary:C}");

            // Keep the console window open
            Console.ReadLine();
        }
        public static SqlConnection GetConnection()
        {
            con =new SqlConnection("Data Source=ICS-LT-6LK96V3\\SQLEXPRESS;Initial Catalog=AssignmentDb;Integrated Security=True");
            con.Open();
            return con;
        }

        static decimal ExecuteInsertEmployee( string name, string gender, decimal salary, out int empId)
        {
            decimal deductedSalary = 0;
            empId = 0;

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    // Create a SqlCommand object for calling the stored procedure
                    using (SqlCommand command = new SqlCommand("InsertEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Salary", salary); // Pass the salary as parameter

                        // Add output parameters to retrieve the EmpId and DeductedSalary
                        SqlParameter empIdParam = new SqlParameter("@EmpId", SqlDbType.Int);
                        empIdParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(empIdParam);

                        SqlParameter deductedSalaryParam = new SqlParameter("@DeductedSalary", SqlDbType.Decimal);
                        deductedSalaryParam.Precision = 10;
                        deductedSalaryParam.Scale = 2;
                        deductedSalaryParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(deductedSalaryParam);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Retrieve the output parameters
                        empId = (int)empIdParam.Value;
                        deductedSalary = (decimal)deductedSalaryParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return deductedSalary;
        }
    }
}
