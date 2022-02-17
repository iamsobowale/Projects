using System;
using System.Collections.Generic;
using Bayo_Libary_Project.Repositories;
namespace Libary_Project
{
    public class Books
    {
        public string BookID;
       public string Author;
       public string Title;
       public string Publisher;
       public int Pages;
       public bool IsAvailable=true;
        private static int NumberOfBooks= 0;
      public static List<Books> books= new List<Books>();

        public Books(string author, string title, string publisher, int pages)
        {
            BookID=GenerateId();
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            AddBooks();
            NumberOfBooks++;
        }
        public void AddBooks()
        {
            books.Add(this);
        }
        public void BookDetails()
        {
             Console.WriteLine($"The Title Of The Book Is {Title} By {Author}, the number of Pages are {Pages} and your book Id is {BookID}");
        }
         public static void PrintDetails()
        {
           for (var i = 0; i < books.Count; i++)
            {
            Console.WriteLine($"{i + 1}.{books[i].Author}-{books[i].Title}-{books[i].BookID}");
            }
        }
         public string GenerateId()
        {
           Random rand =new Random();
            return $"Book{rand.Next(10,50).ToString("000")}";
        }
        public static Books GetBooks(String id)
        {
           foreach (var item in books)
           {
                if (item.BookID ==id ) 
            {
               return item;
               
            }
       
           }
           return null;
        }
        public static void BorrowBook(string BookId)
        {

        }
    }
}