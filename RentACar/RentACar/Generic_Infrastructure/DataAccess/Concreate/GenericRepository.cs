using Generic_Infrastructure.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Generic_Infrastructure.DataAccess.Concreate
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, new() where TContext : DbContext, new()
    {
        public TEntity Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                EntityEntry<TEntity> deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                return deletedEntity.Entity;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> dbSet = context.Set<TEntity>();
                if (includeList != null)
                {
                    foreach (var include in includeList)
                    {
                        dbSet = dbSet.Include(include);
                    }
                }

                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> dbSet = context.Set<TEntity>();
                if (filter != null)
                {
                    dbSet = dbSet.Where(filter);
                }

                if (includeList != null)
                {
                    foreach (var item in includeList)
                    {
                        dbSet = dbSet.Include(item);
                    }
                }

                return dbSet.ToList();
            }
        }

        public TEntity Insert(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                EntityEntry<TEntity> insertedEntity = context.Entry(entity);
                insertedEntity.State = EntityState.Added;
                context.SaveChanges();
                return insertedEntity.Entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                EntityEntry<TEntity> updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return updatedEntity.Entity;
            }
        }
    }
}
