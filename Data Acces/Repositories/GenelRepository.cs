using Data_Acces.Models;
using DataAcces;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Data_Acces.Repositories
{
    public class GenelRepository : IRepository<Genel>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Genel>().Find(id);
            if (entity != null)
                context.Set<Genel>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Genel> GetAll(Expression<Func<Genel, bool>> filter = null)
        {
            return filter == null
                ? context.Set<Genel>().ToList()
                : context.Set<Genel>().Where(filter).ToList();
        }

        public IEnumerable<Genel> Get(Expression<Func<Genel, bool>> filter)
        {
            return context.Set<Genel>().Where(filter).ToList();
        }

        public Genel GetById(object id)
        {
            return context.Set<Genel>().Find(id);
        }
        public Genel GetByPersonelId(int personelId)
        {
            return context.Set<Genel>().Find(personelId);
        }
        public void Insert(Genel entity)
        {
            context.Set<Genel>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Genel entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
