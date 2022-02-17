using System;
using BusMangement.Models;
using BusMangement.Repositories;
using System.Linq;

namespace BusMangement.Menu
{
    public class MainMenu
    {
        ApplicationContext Context = new ApplicationContext();
        public void Menu()
        {
            StaffRepo staffRepo = new StaffRepo(Context);
            DriverRepo driverRepo = new DriverRepo(Context);
            bool stop = true;
            while (stop)
            {
                 Console.WriteLine("Enter 1 for Driver Reg\n Enter 2 To Sign In\nEnter 3 to Terminate");
                 int input = int.Parse(Console.ReadLine());
                 if (input==1)
                 {
                     driverRepo.Creat();
                    // driverRepo.Login();
                 }
                 else if (input==2)
                 {
                     Login();
                 }
                 else if (input==3)
                 {
                     stop = true;
                 }
            }
        }

        public void Login()
        {
            AdminRepo adminRepo = new AdminRepo(Context);
            DriverRepo driverRepo = new DriverRepo(Context);
            StaffRepo staffRepo= new StaffRepo(Context);
            Console.WriteLine("Enter 1 To Login\n Enter 2 for Admin Login");
            int input = int.Parse(Console.ReadLine());
            if (input==1)
            {
                bool DetailsInCorrect = true ;
                while (DetailsInCorrect)
                {
                    Console.WriteLine("Enter Your Id");
                    string id = Console.ReadLine();
                    if (id.StartsWith("Staff"))
                    {
                        var num = (from i in Context.Staves where i.Registration == id select i).SingleOrDefault();
                        if (num != null)
                        {
                            staffRepo.Login();
                            DetailsInCorrect = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid staff Id");
                        }
                    }
                    if (id.StartsWith("Driver"))
                    {
                        var num = (from i in Context.Drivers where i.RegNumber == id select i).SingleOrDefault();
                        //var num =Context.Drivers.Find(id);
                        if (num != null)
                        {
                            driverRepo.Login(id);
                            DetailsInCorrect = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Driver Id Please Try Again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Id Please Try Again");
                    }
                }
            }
            else if (input==2)
            {
                bool end = true;
                while (end)
                {
                    Console.WriteLine("Enter Admin Password");
                    string id = Console.ReadLine();
                    var num = Context.Admins.SingleOrDefault(x => x.Password == id);
                    if (num!=null)
                    {
                       adminRepo.Login();
                       end = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, Try Again");
                    }                
                }
            }
        }
    }
}