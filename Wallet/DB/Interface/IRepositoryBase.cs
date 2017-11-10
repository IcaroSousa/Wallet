using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DB.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> pPredicate);

        bool Add(TEntity pEntity);
        bool Add(IList<TEntity> pEntities);

        int Delete(TEntity pEntity);
        int Delete(IList<TEntity> pEntities);

        int Edit(TEntity pEntity);
        void Save();
    }
}
