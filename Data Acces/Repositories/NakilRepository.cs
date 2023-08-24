using Data_Acces.Models;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAcces.Repositories
{
    public class NakilRepository : IRepository<Nakil>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Nakil>().Find(id);
            if (entity != null)
                context.Set<Nakil>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Nakil> GetAll(Expression<Func<Nakil, bool>> filter = null)
        {
            return filter == null
                ? context.Set<Nakil>().ToList()
                : context.Set<Nakil>().Where(filter).ToList();
        }

        public Nakil GetById(object id)
        {
            return context.Set<Nakil>().Find(id);
        }

        public Nakil GetByPersonelId(int personelId)
        {
            return context.Set<Nakil>().Find(personelId);
        }

        public void Insert(Nakil entity)
        {
            context.Set<Nakil>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Nakil entity)
        {
            context.Set<Nakil>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
