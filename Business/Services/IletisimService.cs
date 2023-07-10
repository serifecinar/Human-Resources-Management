using Business.Interfaces;
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
        public void GetById(int id)
        {
            iletisimRepository.GetById(id);
        }
        public void Update(Iletisim thing)
        {
            iletisimRepository.Update(thing);
        }

        Iletisim IService<Iletisim>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
