using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Doctor
    {
        private int regnNo;
        private string name;
        private int feesCharged;

        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }
        //creating method to display doctor details
        public void DisplayDetails()
        {
            Console.WriteLine($" Registration Number of Doctor's: " + regnNo +","+ $" Doctor's Name : " + name+"," + $" Fees Charged by Doctor: " + feesCharged);
        }

        class Solution
        {
            static void Main(string[] args)
            {
                Doctor d = new Doctor();
                Console.WriteLine("enter the Doctor's registration Number:");
                int regnNo = Convert.ToInt32(Console.ReadLine());
                d.RegnNo = regnNo;
                Console.WriteLine("enter the Doctor's Name:");
                string name = Console.ReadLine();
                d.Name = name;
                Console.WriteLine("enter the Fees Charged by Doctor:");
                int feesCharged = Convert.ToInt32(Console.ReadLine());
                d.FeesCharged = feesCharged;
                d.DisplayDetails();

                Console.Read();
            }
        }
    }
}
