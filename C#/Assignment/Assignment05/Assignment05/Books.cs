using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Books
    {
        private  string BookName{get;set;}
        private string AuthorName { get; set; }
        public  Books(string bookName,string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public  void Display()
        {
            Console.WriteLine($"Book Name:{BookName}");
            Console.WriteLine($"Author Name:{AuthorName}");
        }    
    }
    class BookShelf
    {
        private Books[] books = new Books[5];
        public Books this[int index]
        { 
            get { return books[index]; }
            set { books[index] = value; }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var myBookShelf = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter the Book {i + 1} Name:");
                string bookName = Console.ReadLine();
                Console.WriteLine($"enter the Author{i + 1} Name");
                string authorName = Console.ReadLine();

                var book = new Books(bookName, authorName);
                myBookShelf[i] = book;
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Displaying the Books and their Authors Contents");
            for(int i=0;i<5;i++)
            {
                myBookShelf[i].Display();
            }

            Console.Read();
        }
    }
}
