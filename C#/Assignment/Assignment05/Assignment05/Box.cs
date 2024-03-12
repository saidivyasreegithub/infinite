//Write a class Box that has Length and breadth as its members. 
//    Write a function that adds 2 box objects and stores in the 3rd. 
//    Create a Test class to execute the above.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Box
    {
         public int Length { get; set; }
         public int Breadth { get; set; }

        public Box(int length,int breadth)
        {
            Length=length ;
            Breadth = breadth;
        }
        public Box Add(Box otherBox)
        {
            return new Box(Length + otherBox.Length, Breadth + otherBox.Breadth);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"enter the Box1 Length:");
            int Length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter the Box1 Breadth:"); 
            int Breadth1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter the Box2 length:");
            int Length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter the Box2 Breadth:");
            int Breadth2 = Convert.ToInt32(Console.ReadLine());

            Box box1 = new Box(Length1, Breadth1);
            Box box2 = new Box(Length2, Breadth2);

            Box resBox = box1.Add(box2);
            Console.WriteLine($"Length of Box1:{Length1},Breadth of Box1:{Breadth1}");
            Console.WriteLine($"Length of Box2:{Length2},Breadth of Box2:{Breadth2}");

            Console.WriteLine($"Result Box: Length = {resBox.Length}, Breadth = {resBox.Breadth}");
            Console.Read();
        }
    }
}
