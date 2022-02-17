using System;
namespace Libary_Project
{
    public class Menu
    {
        public static void MainMenu()
        {
           while (true)
           {
               Console.ForegroundColor=ConsoleColor.Green;
               Console.WriteLine("********Welcome To Our Libary********");
               Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("Input 1 to Register User");
                Console.WriteLine("Input 2 to Register Libarian");
                Console.WriteLine("Input 3 for Logging");
                int num=int.Parse(Console.ReadLine());
                if (num==1)
                {
                    Register.UserReg();
                    User.GetUser();
                }
                else if(num==2)
                {
                    Register.LibReg();
                    Libarian.GetLib();
                }
                else if (num==3)
                {
                    LoginMenu.Login();
                }
                else
                {
                  Console.ForegroundColor=ConsoleColor.Red;
                  Console.WriteLine("Invalid Input Try again!");
                   Console.ForegroundColor=ConsoleColor.White; 
                  continue; 
                }
                
           }
            
            
        }
        public static void Lend()
        {
            
            Console.WriteLine("Input 1 to Borrow Books");
            Console.WriteLine("Input 2 to Return Books");
            int num=int.Parse(Console.ReadLine());
           switch (num)
           {
               case 1:
               Borrow();
                   break;
                   case 2:
                   Return();
                   break;
               default:
                   break;
           }
           
        }
        public static void Borrow()
        {
            Lending.Borrow();
        }
         public static void Return()
        {
            Lending.Return();
        }

    }
}