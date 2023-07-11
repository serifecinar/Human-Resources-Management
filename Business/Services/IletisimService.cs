﻿using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces.Interfaces;
using DataAcces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class IletisimService : IService<Iletisim>
    {
        readonly IRepository<Iletisim> iletisimRepository = new IletisimRepository();

        public void Add(Iletisim thing)
        {
            iletisimRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var iletisimData = iletisimRepository.GetAll();

            return iletisimData.ToArray();
        }
        public void Delete(Iletisim thing)
        {
            iletisimRepository.Delete(thing);
        }
        public Iletisim GetById(int id)
        {
            return iletisimRepository.GetById(id);
        }
        public void Update(Iletisim thing)
        {
            iletisimRepository.Update(thing);
        }

        public Iletisim GetByPersonelId(int personelId)
        {
            return iletisimRepository.GetByPersonelId(personelId);
        }
    }
}
