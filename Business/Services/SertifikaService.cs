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
    public class SertifikaService : IService<Sertifika>
    {
        readonly IRepository<Sertifika> sertifikaRepository = new SertifikaRepository();

        public void Add(Sertifika thing)
        {
            sertifikaRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var sertifikaData = sertifikaRepository.GetAll();

            return sertifikaData.ToArray();
        }
        public void Delete(Sertifika thing)
        {
            sertifikaRepository.Delete(thing);
        }
        public void GetById(Sertifika thing)
        {
            sertifikaRepository.GetById(thing);
        }
        public void Update(Sertifika thing)
        {
            sertifikaRepository.Update(thing);
        }
    }
}
