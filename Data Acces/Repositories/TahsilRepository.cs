using Data_Acces.Models;
using DataAcces.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAcces.Repositories
{
    public class TahsilRepository : IRepository<Tahsil>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Tahsil>().Find(id);
            if (entity != null)
                context.Set<Tahsil>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Tahsil> GetAll()
        {
            return context.Set<Tahsil>().ToList();
        }

        public Tahsil GetById(object id)
        {
            return context.Set<Tahsil>().Find(id);
        }

        public Tahsil GetByPersonelId(int personelId)
        {
            return context.Set<Tahsil>().Where(p=> p.PersonelId == personelId).FirstOrDefault();
        }

        public void Insert(Tahsil entity)
        {
            context.Set<Tahsil>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Tahsil entity)
        {
            context.Set<Tahsil>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
