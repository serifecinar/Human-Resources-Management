using Business.Interfaces;
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
    public class NakilService : IService<Nakil>
    {
        readonly IRepository<Nakil> nakilRepository = new NakilRepository();

        public void Add(Nakil thing)
        {
            nakilRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var nakilData = nakilRepository.GetAll();

            return nakilData.ToArray();
        }
        public void Delete(Nakil thing)
        {
            nakilRepository.Delete(thing);
        }
        public void GetById(Nakil thing)
        {
            nakilRepository.GetById(thing);
        }
        public void Update(Nakil thing)
        {
            nakilRepository.Update(thing);
        }
    }
}
