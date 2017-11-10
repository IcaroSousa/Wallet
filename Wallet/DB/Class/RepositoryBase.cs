using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DB.Interface;
using Microsoft.EntityFrameworkCore;

namespace DB.Class
{
    public class RepositoryBase<TContext, TEntity> : IRepositoryBase<TEntity> where TEntity : class where TContext : DbContext, new()
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

        public bool Add(TEntity pEntity)
        {
            _Context.Add(pEntity);
        }

        public bool Add(IList<TEntity> pEntities)
        {
            _Context.AddRange(pEntities.ToArray());
        }

        public int Delete(TEntity pEntity)
        {
            _Context.Remove(pEntity);
        }

        public int Delete(IList<TEntity> pEntities)
        {
            _Context.RemoveRange(pEntities.ToArray());
        }

        public int Edit(TEntity pEntity)
        {

            _Context.Update(pEntity);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> pPredicate)
        {
            
        }

        public IQueryable<TEntity> GetAll()
        {
            return _Context.Find()
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
