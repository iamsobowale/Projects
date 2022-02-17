using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ewallet.Interface;

namespace Ewallet.Repositories
{
    public class BaseRepository<T>:IBaseRepository<T> where T: class
    {
        protected ApplicationContext _context { get; set; }
        public T create(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().FirstOrDefault(expression);
        }

        public List<T> GetMany(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public T Update(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var e = _context.Set<T>().Find(id);
            if (e == null) return false;
            _context.Set<T>().Remove(e);
            _context.SaveChanges();
            return true;
        }
    }
}