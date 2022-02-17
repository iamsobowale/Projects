using System;
using System.Linq;
using Ewallet.Interface;

namespace Ewallet.Repositories
{
    public class PersonRepo : BaseRepository<Person>, IUserRepository
    {
        private ApplicationContext Context;

        public PersonRepo(ApplicationContext context)
        {
            Context = context;
        }

        public Person CreateUser(Person person)
        {
            Context.Persons.Add(person);
            Context.SaveChanges();
            return person;
        }

        public Person GetUser(string email)
        {
            var s = Context.Persons.FirstOrDefault(a => a.Email == email);
            return s;
        }

        public Person GetUser(string Email, string Password)
        {
            var getuser = Context.Persons.FirstOrDefault(a => a.Email == Email && a.Password==Password);
            return getuser;
        }

        public Person GetUser(int id)
        {
            var get = Context.Persons.FirstOrDefault(a => a.Id == id);
            return get;
        }

        public bool DeleteUser(int id)
        {
            var delete = Context.Persons.Find(id);
            Context.Persons.Remove(delete);
            Context.SaveChanges();
            return true;
        }

        public Person Update(Person person)
        {
            Context.Persons.Update(person);
            Context.SaveChanges();
            return person;
        }
    }
}