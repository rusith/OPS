// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using OPS.DAL.Infrastructure.Filters.Abstract;
using OPS.DAL.Dapper;
using OPS.DAL.Infrastructure.Interfaces;
using OPS.DAL.Infrastructure.Models.Concrete;

namespace OPS.DAL.Infrastructure
{
    public abstract class Repository<T> : IRepository<T>
        where T : BaseModel 
    {
        public IDbConnection Conn { get; }
        public IDBContext Context { get;}
        public IUnitOfWork UnitOfWork { get;}

        protected Repository(IDBContext context, IUnitOfWork unitOfWork)
        {
            Context = context;
            Conn = Context.Connection;
            UnitOfWork = unitOfWork;
        }

        public virtual void Add(T entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity", "Add to DB null entity");
            }
            
            entity.DatabaseUnitOfWork = UnitOfWork;           
            var operation = new Operation(OperationType.Add, entity);
            UnitOfWork.AddOp(operation);    
            entity.DatabaseModelStatus = ModelStatus.ToAdd;  
        }

        public virtual void Add(IEnumerable<T> entities, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities", "Add to DB null entity");
            }
            
            foreach(var entity in entities)
                Add(entity, transaction, commandTimeout);
        }

        public virtual void Remove(T entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity", "Remove in DB null entity");
            }
            
            var operation = new Operation(OperationType.Remove, entity);
            UnitOfWork.AddOp(operation);
        }

        public virtual void Remove(IEnumerable<T> entities, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities", "Remove in DB null entity");
            }

            foreach(var entity in entities)
                Remove(entity, transaction, commandTimeout);
        }

        public virtual IEnumerable<T> Get(IRepoQuery query)
        {
            var items = Conn.Get<T>(query).ToList();

            foreach (var item in items)
				AddItemToUnit(item);
            
			return items;
        }

        public virtual async Task<IEnumerable<T>> GetAsync(IRepoQuery query)
        {
            var items = (await Conn.GetAsync<T>(query)).ToList();

            foreach (var item in items)
				AddItemToUnit(item);
            
			return items;
        }

		public virtual T GetFirstOrDefault(IRepoQuery query)
        {
            var item = Conn.Get<T>(query).FirstOrDefault();
			if(item == null)
				return null;
			AddItemToUnit(item);
			return item;
        }


        public virtual async Task<T> GetFirstOrDefaultAsync(IRepoQuery query)
        {
            var item = (await Conn.GetAsync<T>(query)).FirstOrDefault();
			if(item == null)
				return null;
			AddItemToUnit(item);
			return item;
        }

        public virtual int Count(IRepoQuery query)
        {
            return Conn.Count(query);
        }

        public virtual async Task<int> CountAsync(IRepoQuery query)
        {
            return await Conn.CountAsync(query);
        }

		public string GetWhereClause(IRepoQuery query) 
		{
			return Conn.GetWhereClause(query);
		}

		private void AddItemToUnit(T item) 
		{
			item.DatabaseUnitOfWork = UnitOfWork;
            item.DatabaseModelStatus = ModelStatus.Retrieved;
            UnitOfWork.AddObj(item);
		}
    }
}
