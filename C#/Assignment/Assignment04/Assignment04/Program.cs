using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionLibrary
{
    class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private const int TOTAL_FARE = 500;

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter your name:");
            program.Name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            program.Age = Convert.ToInt32(Console.ReadLine());

            TicketConcession concession = new TicketConcession();
            concession.CalculateConcession(program.Age, program.Name);

            Console.ReadKey();
        }
    }


}
    }
}