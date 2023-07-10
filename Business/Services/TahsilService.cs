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
    public class TahsilService : IService<Tahsil>
    {
        readonly IRepository<Tahsil> tahsilRepository = new TahsilRepository();

        public void Add(Tahsil thing)
        {
            tahsilRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var tahsilData = tahsilRepository.GetAll();

            return tahsilData.ToArray();
        }
        public void Delete(Tahsil thing)
        {
            tahsilRepository.Delete(thing);
        }
        public void GetById(int id)
        {
            tahsilRepository.GetById(id);
        }
        public void Update(Tahsil thing)
        {
            tahsilRepository.Update(thing);
        }

        Tahsil IService<Tahsil>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
