using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_project2
{
    class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int price { get; set; }
       // public int QuatityAvaliable { get; set; }

        public void AddProduct()
        {
            Console.WriteLine("Enter product ID :");
            ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product name :");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price :");
            price = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter QuatityAvaliable:");
           
        }

        public void  ShowAllProduct()
        {
           DataAccess.DisplayProduct();
           
        }

        public int GetProductCount()
        {
            int count = DataAccess.GetProductCount();
            return count;
        }
    }

    //Data layer to handle all database activities
    class DataAccess
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-6LK96V3\\SQLEXPRESS; initial catalog=TrainingDb;" +
                "trusted_connection=true");
            con.Open();
            return con;
        }

        //adding a region
        public static void AddProduct(int pid, string pname,float proprice)
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("insert into Products values(@pid,@pname,@proprice)", con);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@pname", pname);
                cmd.Parameters.AddWithValue("@proprice", proprice);
               // cmd.Parameters.AddWithValue("@qty", qty);

                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    Console.WriteLine("Inserted a row.");
                }
                else
                    Console.WriteLine("Could not Insert. Some Problem..");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DisplayProduct()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from products", con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["ProductId"] + " " + dr["Productname"] + " " + dr["Price"]);        
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static int GetProductCount()
        {
            con = getConnection();
            cmd = new SqlCommand("select count(ProductId) from Products", con);
            int Productcount = (int)cmd.ExecuteScalar();
            return Productcount;
        }
    }

    //Client
    class Program
    {
        static void Main(string[] args)
        {
            Products p = new Products();
            Console.WriteLine("Adding a new Product");
            p.AddProduct();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Product Tables Data ");
            p.ShowAllProduct();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Product Count");
            int pno = p.GetProductCount();
            Console.WriteLine("The Total Number of Products present : {0}", pno);
            Console.Read();
        }
    }
}
