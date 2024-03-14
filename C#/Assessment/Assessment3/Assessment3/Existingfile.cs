using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment3
{
    class Existingfile
    {
        static void Main(string[] args)
        {
            string wriitngFilePath = @"C:\saidivyasree\infinite\training\C#\Assessment\Assessment3\appended txt file.txt"; //giving the file path where text will be store

            //string filePath2 = @"C:\saidivyasree\appended txt file.txt"; //this is wrong path to testing the catch exception

            string writingText;

            Console.Write("Please enter text to append: ");
            writingText = Console.ReadLine();

            try
            {
                AppendTextToFile(wriitngFilePath, writingText); //calling the AppendTextToFile function
                Console.WriteLine("Text appended successfully.");
            }
            catch (Exception ex) ////if try not run then it will show exception
            {
                Console.WriteLine("Error is: " + ex.Message);
            }
            Console.ReadKey();
        }

        public static void AppendTextToFile(string wriitngFilePath, string writingText) //creating function AppendTextToFile which takes path and text as parameter
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(wriitngFilePath, true)) //this will create file if not exists
                {
                    writer.WriteLine(writingText); //this will write the text variable value in file
                }
            }
            catch (Exception ex) //if try not run then it will show exception
            {
                throw ex;
            }
        }

    }
}

