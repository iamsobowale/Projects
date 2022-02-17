using System;
using Bayo_Libary_Project.Repositories;
namespace Libary_Project
{
    public class Register
    {
         public static void UserReg()
        {
            Console.WriteLine("Input your Firstame");
            string firstName= Console.ReadLine();
            Console.WriteLine("Input your Lasttame");
            string lastName= Console.ReadLine();
            Console.WriteLine("Input your PhoneNumber");
            string phoneNumber= Console.ReadLine();
            Console.WriteLine("Input your Email");
            string email= Console.ReadLine();
            User users= new User(firstName,lastName,email,phoneNumber);
            AddStudentToFile(users);
             users.UserDetails();
        }
         public static void LibReg()
        {
            Console.WriteLine("Please select 1 for Mr, 2 for Mrs, 3 for Master, 4 For Miss");
            var title=(Prefix)int.Parse(Console.ReadLine());
            Console.WriteLine("Input your Firstame");
            string firstName= Console.ReadLine();
            Console.WriteLine("Input your Lasttame");
            string lastName= Console.ReadLine();
            Console.WriteLine("Input your PhoneNumber");
            string phoneNumber= Console.ReadLine();
            Console.WriteLine("Input your Email");
            string email= Console.ReadLine();
            Libarian lib= new Libarian(firstName,lastName,email,phoneNumber,title);
             lib.UserDetails();
        }
    }
}