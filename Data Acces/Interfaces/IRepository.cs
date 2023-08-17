using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAcces.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // Tüm kayıtları alır.
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);

        // Belirli bir kaydı alır.
        T GetById(object id);

        T GetByPersonelId(int personelId);

        // Yeni bir kayıt ekler.
        void Insert(T entity);

        // Bir kaydı günceller.
        void Update(T entity);

        // Bir kaydı siler.
        void Delete(object id);
    }
}
