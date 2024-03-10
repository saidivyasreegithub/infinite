using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionLibrary
{
    public class TicketConcession
    {
        private const double Total_Fare = 500;
        public void CalculateConcession(int age, string name)
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket for Name: {name} and  Age: {age}");
            }
            else if (age > 60)
            {
                double concessionAmount = Total_Fare * 0.3;
                double fareWithConcession = Total_Fare - concessionAmount;
                Console.WriteLine($"Senior Citizen - Fare after 30% concession: {fareWithConcession:C},for Name: {name} and  Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {Total_Fare:C},for Name: {name} and Age: {age}");
            }
        }
    }
}
