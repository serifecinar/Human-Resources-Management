using Data_Acces.Models;
using DataAcces.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAcces.Repositories
{
    public class IletisimRepository : IRepository<Iletisim>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Iletisim>().Find(id);
            if (entity != null)
                context.Set<Iletisim>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Iletisim> GetAll()
        {
            return context.Set<Iletisim>().ToList();
        }

        public Iletisim GetById(object id)
        {
            return context.Set<Iletisim>().Find(id);
        }

        public void Insert(Iletisim entity)
        {
            context.Set<Iletisim>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Iletisim entity)
        {
            context.Set<Iletisim>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
