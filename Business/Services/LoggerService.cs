using Business.Interfaces;
using DataAcces;
using DataAcces.Interfaces;
using DataAcces.Repositories;
using System;
using System.Linq;

namespace Business.Services
{
    public class LoggerService : IService<Log>
    {
        readonly IRepository<Log> loggerRepository = new LoggerRepository();

        public void Add(Log thing)
        {
            loggerRepository.Insert(thing);
        }

        public Array GetAll()
        {
            var logs = loggerRepository.GetAll();

            return logs.ToArray();
        }
        public void Delete(Log thing)
        {
            loggerRepository.Delete(thing);
        }
        public Log GetById(int id)
        {
           return loggerRepository.GetById(id);
        }
        public void Update(Log thing)
        {
            loggerRepository.Update(thing);
        }

        public Log GetByPersonelId(int personelId)
        {
            return loggerRepository.GetByPersonelId(personelId);
        }
    }
}

