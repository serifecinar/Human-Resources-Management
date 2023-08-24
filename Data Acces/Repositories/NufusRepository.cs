using DataAcces;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Data_Acces.Repositories
{
    public class NufusRepository : IRepository<Nufus>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Nufus>().Find(id);
            if (entity != null)
                context.Set<Nufus>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Nufus> GetAll(Expression<Func<Nufus, bool>> filter = null)
        {
            return filter == null
                ? context.Set<Nufus>().ToList()
                : context.Set<Nufus>().Where(filter).ToList();
        }

        public Nufus GetById(object id)
        {
            return context.Set<Nufus>().Find(id);
        }

        public Nufus GetByPersonelId(int personelId)
        {
            return context.Set<Nufus>().Find(personelId);
        }

        public void Insert(Nufus entity)
        {
            context.Set<Nufus>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Nufus entity)
        {
            context.Set<Nufus>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
