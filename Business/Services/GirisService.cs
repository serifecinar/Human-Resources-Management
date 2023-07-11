﻿using Business.Interfaces;
using Data_Acces.Models;
using Data_Acces.Repositories;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class GirisService :IService<Giris>
    {
        readonly IRepository<Giris> girisRepository = new GirisRepository();

        public void Add(Giris thing)
        {
            girisRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var genelData = girisRepository.GetAll();

            return genelData.ToArray();
        }
        public void Delete(Giris thing)
        {
            girisRepository.Delete(thing);
        }
        public Giris GetById(int id)
        {
           return girisRepository.GetById(id);
        }
        public void Update(Giris thing)
        {
            girisRepository.Update(thing);
        }

        public Giris GetByPersonelId(int personelId)
        {
            return girisRepository.GetByPersonelId(personelId);
        }
    }
}
