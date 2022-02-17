using System.Collections.Generic;
using Bayo_Libary_Project.Models;
using System.IO;
using System;
namespace Bayo_Libary_Project.Repositories
{
    public class UserRepository
    {
        Books book=new Books();
        List<User> users=new List<User>();
        string file ="C:\\Users\\user\\Desktop\\c#\\Bayo Libary Project\\Files\\UserFile.txt";
         public UserRepository()
      {
          ReadUserFromFile();
      }
      private void ReadUserFromFile()
      {
          try
          {
                if (File.Exists(file))
            {
                var allStudents=File.ReadAllLines(file);
                foreach (var s in allStudents)
                {
                    User st=User.ToUser(s);
                    users.Add(st);
                }
            }
            else
            {
                string path="File";
                Directory.CreateDirectory(path);
                string fileName="Bayo_Libary_Project";
                string fullpath= Path.Combine(path, fileName);
                File.Create(file);
            }  
          }
          catch (System.Exception ex)
          {
               Console.WriteLine(ex.Message);
          }       
        }
        private void AddStudentToFile(User user)
        {
            try
            {
                using(StreamWriter write = new StreamWriter(file, true))
            {
                write.WriteLine(user.ToString());
            } 
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
       public User UserReg()
        {
            Console.WriteLine("Input your Firstame");
            string firstName= Console.ReadLine();
            Console.WriteLine("Input your Lasttame");
            string lastName= Console.ReadLine();
            Console.WriteLine("Input your PhoneNumber");
            string phoneNumber= Console.ReadLine();
            Console.WriteLine("Input your Email");
            string email= Console.ReadLine();
            User user= new User(firstName,lastName,email,phoneNumber);
            users.Add(user);
            AddStudentToFile(user);
            return user;
            //  users.UserDetails();
        }
        private void PrintUser(User users)
        {
            Console.WriteLine(users.ToString());
        }
         public void GetAll()
        {
            if (users.Count==0)
            {
                Console.WriteLine("There is not Student register yet");
            }
            foreach (var user in users)
            {
                PrintUser(user);
            }
        }
         public void GetUser()
        {
            Console.WriteLine("Input your UserId");
            var id =Console.ReadLine();
           foreach (var item in users)
           {
                if (item.IdNumber ==id)
            {
                Console.WriteLine("Welcome to Libary");
                UserPortfolios();
            }
            else
            {
                Console.WriteLine("Invalid UserId");
                break;
            }
           }
        }
         public  void UserPortfolios()
        {
            while (true)
            {
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.WriteLine("Input 1 to view Available books, Input 2 to Access Books, Input 3 To go back to MainMenu");
                Console.ForegroundColor=ConsoleColor.White;
                var Input=int.Parse(Console.ReadLine());
                if (Input==1)
                {
                    Books.PrintDetails(); 

                }
                else if (Input==2)
                {
                    Menu.Lend();
                }
                else if(Input==3)
                {
                Menu.MainMenu();
                break;
                }
                else
                {
                     Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Invalid Selection");
                    Console.ForegroundColor=ConsoleColor.White;
                    continue;
                }
            }
            
        }

    }
}