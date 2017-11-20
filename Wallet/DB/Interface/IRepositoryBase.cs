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

        void Add(TEntity pEntity);
        void Add(List<TEntity> pEntities);

        void Delete(TEntity pEntity);
        void Delete(IList<TEntity> pEntities);

        void Update(TEntity pEntity);
        void Update(List<TEntity> pEntities);
        void Save();
    }
}
