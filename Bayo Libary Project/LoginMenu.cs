using System;
namespace Libary_Project
{
    public class LoginMenu
    {
         public static void Login()
        {
           Console.WriteLine("Input 1 for UserLogin, Input 2 for Staff Login");
           var Input=int.Parse(Console.ReadLine());
          if (Input==1)
          {
                 User.GetUser();
          }
          else if (Input==2)
          {
               Libarian.GetLib();
          }
          else
          {
               Console.WriteLine("Invalid Selection Try Again!");
               LoginMenu.Login();
          }
        }
    }
  
}
