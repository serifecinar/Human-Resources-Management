using DataAcces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Interfaces
{
    public interface IService<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T thing);
        void Delete(T thing);
        void Update(T thing);
        T GetById(int id);
        T GetByPersonelId(int personelId);
    }
}
