
using System;
using System.Collections.Generic;
using GenericRepository.Models;

namespace GenericRepository.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);

    }

}