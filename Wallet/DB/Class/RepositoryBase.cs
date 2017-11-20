using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DB.Interface;
using Microsoft.EntityFrameworkCore;

namespace DB.Class
{
    public abstract class RepositoryBase<TContext, TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase where TContext : DbContext, new()
    {

        TContext _Context;
        public TContext Context
        {
            get { return _Context; }
            set { _Context = value; }
        }

        protected RepositoryBase()
        {
            _Context = new TContext();
            _Context.Database.EnsureCreatedAsync();
        }

        public virtual void Add(TEntity pEntity)
        {
            pEntity.DateOfCreation = DateTime.Now;
            _Context.Set<TEntity>().Add(pEntity);
        }

        public virtual void Add(List<TEntity> pEntities)
        {
            pEntities.ForEach(pX => pX.DateOfCreation = DateTime.Now);
            _Context.Set<TEntity>().AddRange(pEntities.ToArray());
        }

        public virtual void Update(List<TEntity> pEntities)
        {
            pEntities.ForEach(pX => pX.DateOfUpdate = DateTime.Now);
            _Context.Set<TEntity>().UpdateRange(pEntities.ToArray());
        }

        public virtual void Update(TEntity pEntity)
        {
            pEntity.DateOfUpdate = DateTime.Now;
            _Context.Set<TEntity>().Update(pEntity);
        }

        public virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> pPredicate) => _Context.Set<TEntity>().Where(pPredicate);

        public virtual IQueryable<TEntity> GetAll() => _Context.Set<TEntity>();

        public virtual void Delete(Expression<Func<TEntity, bool>> pPredicate)
        {
            TEntity[] lData = FindBy(pPredicate).ToArray();
            Delete(lData);
        }

        public virtual void Delete(TEntity pEntity) => _Context.Set<TEntity>().Remove(pEntity);

        public virtual void Delete(IList<TEntity> pEntities) => _Context.Set<TEntity>().RemoveRange(pEntities.ToArray());

        public virtual void Save()
        {
            _Context.SaveChanges();
        }
    }
}
