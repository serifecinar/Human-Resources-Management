using Data_Acces.Models;
using DataAcces;
using DataAcces.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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

        public IEnumerable<Genel> GetAll()
        {
            return context.Set<Genel>().ToList();
        }

        public Genel GetById(object id)
        {
            return context.Set<Genel>().Find(id);
        }

        public void Insert(Genel entity)
        {
            context.Set<Genel>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Genel entity)
        {
            context.Set<Genel>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
