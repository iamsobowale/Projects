using System;
namespace Libary_Project
{
    public class Lending
    {
    public static void Borrow()
     {
         
            Console.WriteLine("Input Book Id");
            var id =Console.ReadLine();
       Books b = Books.GetBooks(id);
       if (b != null)
       {
            if(b.IsAvailable)
                {
                    b.IsAvailable = false;
                    Console.WriteLine("Book Is Borrowed");
                }
                else
                {
                   Console.WriteLine("The Book is unavaliable"); 
                }
       }

     }
      public static void Return()
     {
      
       Console.WriteLine("Input Book Id");
       var id =Console.ReadLine();
       Books b = Books.GetBooks(id);
       if (b != null)
       {
            if(b.IsAvailable)
                {
                    b.IsAvailable = false;
                    Console.WriteLine("Book Is Returned");
                }
                else
                {
                   Console.WriteLine("The Book is unavaliable"); 
                }
       }

     }

    }
}