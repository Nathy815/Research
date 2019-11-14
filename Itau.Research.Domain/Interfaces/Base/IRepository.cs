using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Itau.Research.Domain.Models;

namespace Itau.Research.Domain.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        T Insert(T model);
        T Update(T model);
        void Delete(T model);
        void Recover(T model);
        IQueryable<T> GetAll();
        T Find(Expression<Func<T, bool>> where);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> where);
    }
}
