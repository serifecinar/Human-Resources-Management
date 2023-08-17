using Business.Interfaces;
using Data_Acces.Repositories;
using DataAcces;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Services
{
    public class NufusService : IService<Nufus>
    {
        readonly IRepository<Nufus> nufusRepository = new NufusRepository();

        public void Add(Nufus thing)
        {
            nufusRepository.Insert(thing);
        }

        public List<Nufus> GetAll(Expression<Func<Nufus, bool>> filter = null)
        {
            var nufusData = nufusRepository.GetAll(filter);

            return nufusData.ToList();
        }

        public void Delete(Nufus thing)
        {
            nufusRepository.Delete(thing);
        }

        public Nufus GetById(int id)
        {
            return nufusRepository.GetById(id);
        }

        public void Update(Nufus thing)
        {
            nufusRepository.Update(thing);
        }

        public Nufus GetByPersonelId(int personelId)
        {
            return nufusRepository.GetByPersonelId(personelId);
        }
    }
}
