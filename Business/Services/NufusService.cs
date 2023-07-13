﻿using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class NufusService : IService<Nufus>
    {
        readonly IRepository<Nufus> nufusRepository = new NufusRepository();

        public void Add(Nufus thing)
        {
            nufusRepository.Insert(thing);
        }

        public List<Nufus> GetAll()
        {
            var nufusData = nufusRepository.GetAll();

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
