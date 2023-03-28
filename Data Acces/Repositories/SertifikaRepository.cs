using Data_Acces.Models;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Repositories
{
    public class SertifikaRepository : IRepository<Sertifika>
    {
        private readonly Context context = new Context();

        public void Delete(object id)
        {
            var entity = context.Set<Sertifika>().Find(id);
            if (entity != null)
                context.Set<Sertifika>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Sertifika> GetAll()
        {
            return context.Set<Sertifika>().ToList();
        }

        public Sertifika GetById(object id)
        {
            return context.Set<Sertifika>().Find(id);
        }

        public void Insert(Sertifika entity)
        {
            context.Set<Sertifika>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Sertifika entity)
        {
            context.Set<Sertifika>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }


    }
}
