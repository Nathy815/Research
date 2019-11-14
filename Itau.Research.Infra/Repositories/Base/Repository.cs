using Itau.Research.Domain.Interfaces;
using Itau.Research.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Itau.Research.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private readonly DbContext _context;
        private DbSet<T> entity;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public T Insert(T model)
        {
            model.Id = new Guid();
            entity.Add(model);
            _context.SaveChanges();
            return model;
        }

        public T Update(T model)
        {
            entity.Update(model);
            _context.SaveChanges();
            return model;
        }

        public void Delete(T model)
        {
            model.Active = false;
            entity.Update(model);
            _context.SaveChanges();
        }

        public void Recover(T model)
        {
            model.Active = true;
            entity.Update(model);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return entity;
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return entity.Where<T>(where).FirstOrDefault();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> where)
        {
            return entity.Where<T>(where);
        }
    }
}
