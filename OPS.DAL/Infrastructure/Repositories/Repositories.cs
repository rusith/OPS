// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using System.Linq;
using System.Threading.Tasks;
using OPS.DAL.Infrastructure.Interfaces;
using OPS.DAL.Infrastructure.Models.Abstract.Context;
using OPS.DAL.Infrastructure.Models.Concrete;
using OPS.DAL.Infrastructure.Models.Concrete.Context;
using OPS.DAL.Infrastructure.Repositories.Abstract;

namespace OPS.DAL.Infrastructure.Repositories
{

    namespace Abstract
    {

        /// <summary>
        /// An API to access data of the data source Order
        /// </summary>
	    public interface IOrderRepository : IRepository<Order>
	    {
            /// <summary>
            /// Get a new query context to query the data source
            /// </summary>
            /// <returns>A query context</returns>
		    IOrderQueryContext Get();

            /// <summary>
            /// Get an object of Order using the values of its primary key(s)
            /// </summary>

            /// <param name="id">Value for primary key ID</param>
            /// <returns>A registered Order object</returns>
            Order GetByKey(int id);
            
            /// <summary>
            /// Get an object of Order asynchronously using the values of its primary key(s)
            /// </summary>

            /// <param name="id">Value for primary key ID</param>
            /// <returns>A registered Order object</returns>
            Task<Order> GetByKeyAsync(int id);
            
            /// <summary>
            /// Remove an object of Order using the values of its primary key(s)
            /// </summary>

            /// <param name="id">Value for primary key ID</param>
            void RemoveByKey(int id);

	    }




    }

    namespace Concrete
    {
	    internal class OrderRepository : Repository<Order> , IOrderRepository
	    {
            internal OrderRepository(IDBContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
            {
            }

		    public IOrderQueryContext Get() { return new OrderQueryContext(this); }


            public Order GetByKey(int id)
		    {
                return Get().Where
                    .ID.EqualsTo(id).Filter().FirstOrDefault();
            }

            public async Task<Order> GetByKeyAsync(int id)
            {
                return await Get().Where
                    .ID.EqualsTo(id).Filter().FirstOrDefaultAsync();
            }

            public void RemoveByKey(int id)
            {
                Remove(new Order
                {
                                        ID = id,

                    DatabaseModelStatus = ModelStatus.Retrieved
                });
            }

	    }



    }
}
