using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private ObservableCollection<TEntity> Entities;
        public Repository(ObservableCollection<TEntity> entites)
        {
            this.Entities = entites;
        }
        public void Add(TEntity entity)
        {
            this.Entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Entities.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.Entities;
        }
    }
}
