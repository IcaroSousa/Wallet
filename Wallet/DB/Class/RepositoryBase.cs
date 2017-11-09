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
        
        private TContext _Context = new TContext();
        public TContext Context
        {
            get { return _Context; }
            set { _Context = value; }
        }

        public RepositoryBase()
        {
            
        }

        public bool Add(TEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public bool Add(IList<TEntity> pEntities)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public int Delete(IList<TEntity> pEntities)
        {
            throw new NotImplementedException();
        }

        public int Edit(TEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> pPredicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
