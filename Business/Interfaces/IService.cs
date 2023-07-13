using System;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IService<T> where T : class
    {
        List<T> GetAll();
        void Add(T thing);
        void Delete(T thing);
        void Update(T thing);
        T GetById(int id);
        T GetByPersonelId(int personelId);
    }
}
