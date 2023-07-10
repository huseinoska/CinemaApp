﻿using Kino.Domain.DomainModels;
using Kino.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kino.Repository.Implementation /*201227*/
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext context;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            entities.Remove(entity);
            context.SaveChanges();
        }

        public T Get(Guid? id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
           return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
           if(entity == null) throw new ArgumentNullException(nameof(entity));
           entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof (entity));
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
