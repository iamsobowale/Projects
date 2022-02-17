using System;
namespace Ewallet.Interface
{
    public interface IUserRepository
    { 
        Person CreateUser(Person person);
        Person GetUser(string email);
        Person GetUser(string email, string password);
        Person GetUser(int id);
        Person Update(Person person);
        bool DeleteUser(int id);
    }
}