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
    public class NakilService : IService<Nakil>
    {
        readonly IRepository<Nakil> nakilRepository = new NakilRepository();

        public void Add(Nakil thing)
        {
            nakilRepository.Insert(thing);
        }

        public List<Nakil> GetAll(Expression<Func<Nakil, bool>> filter = null)
        {
            var nakilData = nakilRepository.GetAll(filter);

            return nakilData.ToList();
        }
        public void Delete(Nakil thing)
        {
            nakilRepository.Delete(thing);
        }
        public Nakil GetById(int id)
        {
            return nakilRepository.GetById(id);
        }
        public void Update(Nakil thing)
        {
            nakilRepository.Update(thing);
        }
        public Nakil GetByPersonelId(int personelId)
        {
            return nakilRepository.GetByPersonelId(personelId);
        }
    }
}
