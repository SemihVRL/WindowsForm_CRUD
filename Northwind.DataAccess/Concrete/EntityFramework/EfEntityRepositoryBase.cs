﻿using Northwind.DataAccess.Abstract;
using Northwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity , TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }
       
       
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);


            }
        }



        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();


            }
        }

        public void Delete(TEntity entity)
        {   
            using (TContext context = new TContext())
            {
                var DeletedEntity = context.Entry(entity);
                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }

        }


        public void update(TEntity entity)
        {

            using (TContext context = new TContext())
            {
                var UptatedEntity = context.Entry(entity);
                UptatedEntity.State = EntityState.Modified;
                context.SaveChanges();


            }

        }
    }
}
