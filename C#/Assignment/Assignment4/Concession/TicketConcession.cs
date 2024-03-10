using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession // changing the class name with TicketConcession
    {
        public void CalculateConcession(int age, string name) //creating function calculateConcession
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket, Name: {name} and  Age: {age}");
            }
            else if (age > 60)
            {
                decimal seniorCitizenFare = 500 * .3m;
                Console.WriteLine($"Senior Citizen - {seniorCitizenFare}, Name: {name} and Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - {500}, Name: {name} and Age: {age}");
            }
        }
    }
}
