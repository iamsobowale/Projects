using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ewallet.Interface
{
    public interface IBaseRepository<T>
    {
        T create(T obj);
        T Get(Expression<Func<T, bool>> expression);
        List<T> GetMany(Expression<Func<T, bool>> expression);
        T Update(T obj);
        bool Delete(int id);
    }
}