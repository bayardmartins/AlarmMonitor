using AlarmMonitor.Application.Interfaces;
using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Services
{
    public class EntityServiceApplication<TEntity> : IEntityServiceApplication<TEntity>
        where TEntity : Entity
    {
        protected readonly IEntityService<TEntity> service;

        public EntityServiceApplication(IEntityService<TEntity> service)
            : base()
        {
            this.service = service;
        }

        public void Add(TEntity entity)
        {
            service.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            service.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return service.GetAll();
        }
    }
}
