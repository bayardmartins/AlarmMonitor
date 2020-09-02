using AlarmMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Interfaces.Services
{
    public interface IEntityService<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
    }
}
