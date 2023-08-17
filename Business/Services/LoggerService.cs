using Business.Interfaces;
using Data_Acces.Models;
using DataAcces;
using DataAcces.Interfaces;
using DataAcces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Services
{
    public class LoggerService : IService<Log>
    {
        readonly IRepository<Log> loggerRepository = new LoggerRepository();

        public void Add(Log thing)
        {
            loggerRepository.Insert(thing);
        }

        public List<Log> GetAll(Expression<Func<Log, bool>> filter = null)
        {
            var logs = loggerRepository.GetAll(filter);

            return logs.ToList();
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

