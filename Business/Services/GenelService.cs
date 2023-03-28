using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces.Interfaces;
using System;
using System.Linq;

namespace Business.Services
{
    public class GenelService : IService<Genel>
    {
        readonly IRepository<Genel> genelRepository = new GenelRepository();

        public void Add(Genel thing)
        {
            genelRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var genelData = genelRepository.GetAll();

            return genelData.ToArray();
        }
        public void Delete(Genel thing)
        {
            genelRepository.Delete(thing);
        }
        public void GetById(Genel thing)
        {
            genelRepository.GetById(thing);
        }
         public void Update(Genel thing)
        {
            genelRepository.Update(thing);
        }
    }
}
