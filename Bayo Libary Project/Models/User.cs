using Libary_Project;
using System;
using Bayo_Libary_Project.Repositories;
namespace Bayo_Libary_Project.Models
{
    public class User:Person
    {
        public string IdNumber{ get;}
         private static int NumberOfUsers = 0;
        public User(string firstName, string lastName, string phoneNumber, string email):base( firstName, lastName, phoneNumber, email)
        {
            IdNumber=GenerateId();
            // AddStudent();
            NumberOfUsers++;
        }
        public User(string firstName, string lastName, string phoneNumber, string email, string id):base( firstName, lastName, phoneNumber, email)
        {
          IdNumber=id;  
        }
        public override string ToString()
        {
            return $"{FirstName}\t{LastName}\t{PhoneNumber}\t{Email}\t{IdNumber}";
        }
        public static User ToUser(string user)
        {
            var users=user.Split("\t");
            var id=(users[0]);
            var firstName=users[1];
            var lastName=users[2];
            var phoneNumber=users[3];
            var email=users[4];
            User n =new User(id,firstName, lastName, phoneNumber,email); 
            return n;
        } 
         public string GenerateId()
        {
            Random rand =new Random();
            return $"User{rand.Next(10,50).ToString("000")}";
        }
    }
}