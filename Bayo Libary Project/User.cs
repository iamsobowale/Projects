using System;
using System.Collections.Generic;
namespace Libary_Project
{
    public class User:Person
    {
         public string IdNumber{ get;}

           private static int NumberOfUsers = 0;
           public static List<User> users = new List<User>();

        public User(string firstName, string lastName, string phoneNumber, string email):base( firstName, lastName, phoneNumber, email)
        {
            IdNumber=GenerateId();
            AddStudent();
            NumberOfUsers++;
        }
        public void UserDetails()
        {
            Console.WriteLine($"{FirstName} Welcome to Our Libary, your Id number is {IdNumber}");
        }
        public void AddStudent()
        {
            users.Add(this);
        }
        public string GenerateId()
        {
            Random rand =new Random();
            return $"User{rand.Next(10,50).ToString("000")}";
        }
       
        public static void PrintDetails()
        {
           for (var i = 0; i < users.Count; i++)
            {
            Console.WriteLine($"{i + 1}.{users[i].FirstName}-{users[i].LastName}-{users[i].Email}{users[i].IdNumber}");
            }
        }

        public static void GetUser()
        {
            Console.WriteLine("Input your UserId");
            var id =Console.ReadLine();
           foreach (var item in users)
           {
                if (item.IdNumber ==id)
            {
                Console.WriteLine("Welcome to Libary");
                UserPortfolio.UserPortfolios();
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