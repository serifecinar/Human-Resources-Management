using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces.Interfaces;
using System.Collections.Generic;
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

        public void Delete(Genel thing) => genelRepository.Delete(thing);

        public Genel GetById(int id) => genelRepository.GetById(id);

        public void Update(Genel thing) => genelRepository.Update(thing);

        public Genel GetByPersonelId(int personelId)
        {
            return genelRepository.GetByPersonelId(personelId); 
        } 

        public List<Genel> GetAll() => genelRepository.GetAll().ToList();
    }
}
