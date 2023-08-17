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
    public class GirisRepository : IRepository<Giris>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Giris>().Find(id);
            if (entity != null)
                context.Set<Giris>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Giris> GetAll(Expression<Func<Giris, bool>> filter = null)
        {
            return filter == null
                ? context.Set<Giris>().ToList()
                : context.Set<Giris>().Where(filter).ToList();
        }

        public Giris GetById(object id)
        {
            return context.Set<Giris>().Find(id);
        }

        public Giris GetByPersonelId(int personelId)
        {
            return context.Set<Giris>().Find(personelId);
        }

        public void Insert(Giris entity)
        {
            context.Set<Giris>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Giris entity)
        {
            context.Set<Giris>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
