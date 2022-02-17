using System;
using System.Collections.Generic;
namespace Libary_Project
{
    public class Libarian:Person
    {
         public string IdNumber{ get;}

        //    public Books UserBooks { get; set; }
        //    private static int NumberOfUsers = 0;
         public static List<Libarian> lib = new List<Libarian>();

        public Libarian(string firstName, string lastName, string phoneNumber, string email):base(firstName, lastName, phoneNumber, email)
        {
            IdNumber=GenerateId();
            AddBooks();  
        }
        public string GenerateId()
        {
            Random rand =new Random();
            return $"Lib{rand.Next(10,50).ToString("000")}";
        }
         public void AddBooks()
        {
            lib.Add(this);
        }
        public void UserDetails()
        {
            Console.WriteLine($"{FirstName} Thank you for choosing to work with us, your Id number is {IdNumber}");
        }
        public void PrintLibDetails()
        {
           for (var i = 0; i < lib.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lib[i].FirstName}-{lib[i].LastName}-{lib[i].Email}{lib[i].IdNumber}");
            }
        }
         public static void GetLib()
        {
            Console.WriteLine("Input Liberian UserId");
            var id =Console.ReadLine();
           foreach (var item in lib)
           {
                if (item.IdNumber ==id)
            {
                Console.WriteLine("Welcome Back");
                AddBooksToLibary.AddBook();
            }
            else
            {
                Console.WriteLine("Invalid UserId");
                break;
            }
           }
        }
    }
}