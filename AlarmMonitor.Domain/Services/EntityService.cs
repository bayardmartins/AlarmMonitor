using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using AlarmMonitor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Services
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> _repository;

        public EntityService(IRepository<TEntity> repository)
        {
            this._repository = repository;
        }
        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

    }
}
