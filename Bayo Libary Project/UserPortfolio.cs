using System;
namespace Libary_Project
{
    public class UserPortfolio
    {
         public void UserPortfolios()
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