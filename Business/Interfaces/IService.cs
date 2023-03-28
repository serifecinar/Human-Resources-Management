using System;

namespace Business.Interfaces
{
    public interface IService<T> where T : class
    {
        Array GetAll();
        void Add(T thing);
        void Delete(T thing);
        void Update(T thing);
        void GetById(T thing);
    }
}
