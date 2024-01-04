using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Generic_Infrastructure.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includeList);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
