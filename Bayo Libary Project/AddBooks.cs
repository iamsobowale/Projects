using System;
namespace Libary_Project
{
    public class AddBooksToLibary
    {
         public static void AddBook()
        {
            
            Console.WriteLine("Input 1 to Add Books");
            Console.WriteLine("Input 2 to Print Books");
            int num=int.Parse(Console.ReadLine());
           switch (num)
           {
               case 1:
               Add();
                   break;
                   case 2:
                PrintBooks();
                   break;
               default:
                   break;
           }
           
        }
        public static void Add()
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("******How many Books are you registering******");
             Console.ForegroundColor=ConsoleColor.White;
            var numberOfBooks= int.Parse(Console.ReadLine());
             for (var i = 0; i < numberOfBooks; i++)
           {
            Console.WriteLine("Input Author name");
            string author= Console.ReadLine();
            Console.WriteLine("Input Publisher Name");
            string publisher= Console.ReadLine();
            Console.WriteLine("Input Title");
            string title= Console.ReadLine();
            Console.WriteLine("Number Of Pages");
            int pages= int.Parse(Console.ReadLine());
            Books book= new Books(author, title, publisher, pages);
            book.BookDetails();
            }
        }
        public static void PrintBooks()
        {
            Books.PrintDetails();
        }
    }
}