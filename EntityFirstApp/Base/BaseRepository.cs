using EntityFirstApp.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Base
{
    public abstract class BaseRepository<T,D> where T :class where D : DataContext, new() 
    {
        private D _dataContext;
        public IDbSet<T> Dbset;
       
        protected BaseRepository(IDatabaseFactory<D> databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            Dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory<D> DatabaseFactory
        {
            get;
            private set;
        }

        public DataContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }

        public virtual T Add(T entity)
        {
            T result = entity;
                  
            Dbset.Add(entity);
            DataContext.Entry(entity).State = EntityState.Added;
            result = entity;
            
            return result;
        }

        public virtual void Update(T entity)
        {
            if (DataContext.Entry(entity).State != EntityState.Detached)
            {
                Dbset.Attach(entity);
                DataContext.Entry(entity).State = EntityState.Modified;
            }
        }

        public virtual void Delete(T entity)
        {
            Dbset.Remove(entity);
            DataContext.Entry(entity).State = EntityState.Deleted;
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = Dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                Dbset.Remove(obj);
        }

        public virtual T GetById(object id)
        {
            return Dbset.Find(id);
        }
    }
}
