using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class Repository<T> : IRepository<T>, IUnitOfWork where T : class
    {
        ADbContext context;
        IDbContextTransaction transaction;

        public Repository(ADbContext context)
        {
            this.context = context;
            this.transaction =context.Database.BeginTransaction();
        }

        public bool Add(T model)
        {
            context.Set<T>().Add(model);
            return true;
        }

        public bool Commit(bool state = true)
        {
            Save();
            if (state)
            {
                transaction.Commit();    
            }
            transaction.Rollback(); 
            Dispose();
            return true;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<T> Get()
        {
           return context.Set<T>().ToList();
        }

        public bool Remove(T model)
        {
            context.Set<T>().Remove(model);
            return true; 
        }

        public int Save()
        {
           return context.SaveChanges();

        }
    }
}
