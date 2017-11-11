using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DB.Interface;
using Microsoft.EntityFrameworkCore;

namespace DB.Class
{
    public abstract class RepositoryBase<TContext, TEntity> : IRepositoryBase<TEntity> where TEntity : class where TContext : DbContext, new()
    {

        TContext _Context;
        public TContext Context
        {
            get { return _Context; }
            set { _Context = value; }
        }

        public RepositoryBase()
        {
            _Context = new TContext();
        }

        public virtual void Add(TEntity pEntity) => _Context.Set<TEntity>().Add(pEntity);

        public virtual void Add(IList<TEntity> pEntities) => _Context.Set<TEntity>().AddRange(pEntities.ToArray());

        public virtual void Delete(TEntity pEntity) => _Context.Set<TEntity>().Remove(pEntity);

        public virtual void Delete(IList<TEntity> pEntities) => _Context.Set<TEntity>().RemoveRange(pEntities.ToArray());

        public virtual void Edit(TEntity pEntity) => _Context.Set<TEntity>().Update(pEntity);

        public virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> pPredicate) => _Context.Set<TEntity>().Where(pPredicate);

        public virtual IQueryable<TEntity> GetAll() => _Context.Set<TEntity>();

        public virtual void Save() => _Context.SaveChanges();
    }
}
