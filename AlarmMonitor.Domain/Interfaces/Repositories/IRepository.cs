using AlarmMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmMonitor.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
    }
}
