﻿using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces.Interfaces;
using DataAcces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SertifikaService : IService<Sertifika>
    {
        readonly IRepository<Sertifika> sertifikaRepository = new SertifikaRepository();

        public void Add(Sertifika thing)
        {
            sertifikaRepository.Insert(thing);
        }

        public List<Sertifika> GetAll(Expression<Func<Sertifika, bool>> filter = null)
        {
            var sertifikaData = sertifikaRepository.GetAll(filter);

            return sertifikaData.ToList();
        }
        public void Delete(Sertifika thing)
        {
            sertifikaRepository.Delete(thing);
        }
        public Sertifika GetById(int id)
        {
            return sertifikaRepository.GetById(id);
        }
        public void Update(Sertifika thing)
        {
            sertifikaRepository.Update(thing);
        }
        public Sertifika GetByPersonelId(int personelId)
        {
            return sertifikaRepository.GetByPersonelId(personelId);
        }
    }
}
