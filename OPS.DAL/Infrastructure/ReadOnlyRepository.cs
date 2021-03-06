// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using OPS.DAL.Dapper;
using OPS.DAL.Infrastructure.Interfaces;
using OPS.DAL.Infrastructure.Filters.Abstract;

namespace OPS.DAL.Infrastructure
{
    public class ReadOnlyRepository<T> : IReadOnlyRepository<T>
        where T : class
    {
        public IDbConnection Conn { get; }
        public IDBContext Context { get;}

        protected ReadOnlyRepository(IDBContext context)
        {
            Context = context;
            Conn = Context.Connection;
        }

	    public virtual T GetFirstOrDefault(IRepoQuery query)
        {
            return Conn.Get<T>(query).FirstOrDefault();
        }


        public virtual async Task<T> GetFirstOrDefaultAsync(IRepoQuery query)
        {
            return (await Conn.GetAsync<T>(query)).FirstOrDefault();
        }

        public virtual IEnumerable<T> Get(IRepoQuery query)
        {
            return Conn.Get<T>(query).ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAsync(IRepoQuery query)
        {
            return (await Conn.GetAsync<T>(query)).ToList();
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
    }
}

