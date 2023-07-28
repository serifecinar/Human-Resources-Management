using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Services
{
    public class GenelService : IService<Genel>
    {
        GenelRepository genelRepository = new GenelRepository();

        public void Add(Genel thing)
        { 
            genelRepository.Insert(thing);
        }

        public void Delete(Genel thing) => genelRepository.Delete(thing);

        public Genel GetById(int id) => genelRepository.GetById(id);

        public void Update(Genel thing) => genelRepository.Update(thing);

        public Genel GetByPersonelId(int personelId) => genelRepository.GetByPersonelId(personelId); 
       
        public List<Genel> GetAll() => genelRepository.GetAll().ToList();
        public List<Genel> Get(Expression<Func<Genel, bool>> filter) => genelRepository.Get(filter).ToList();
    }
}
