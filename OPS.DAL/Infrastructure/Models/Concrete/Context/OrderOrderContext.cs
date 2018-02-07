// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using OPS.DAL.Infrastructure.Models.Abstract;
using OPS.DAL.Infrastructure.Filters.Abstract;
using OPS.DAL.Infrastructure.Filters.Concrete;
using OPS.DAL.Infrastructure.Models.Abstract.Context;

namespace OPS.DAL.Infrastructure.Models.Concrete.Context
{
	public class OrderOrderContext : BaseOrderContext, IOrderOrderContext
    {
		private readonly IOrderQueryContext  _queryContext;
		internal OrderOrderContext(IOrderQueryContext context) { _queryContext = context; }
        private IOrderElement<IOrderOrderContext, IOrderQueryContext> _iD;
        private IOrderElement<IOrderOrderContext, IOrderQueryContext> _quantity;
        private IOrderElement<IOrderOrderContext, IOrderQueryContext> _remarks;


	    public IOrderElement<IOrderOrderContext, IOrderQueryContext> ID { get { return _iD ?? ( _iD = new OrderElement<IOrderOrderContext, IOrderQueryContext>("ID", this, _queryContext)); } }
	    public IOrderElement<IOrderOrderContext, IOrderQueryContext> Quantity { get { return _quantity ?? ( _quantity = new OrderElement<IOrderOrderContext, IOrderQueryContext>("Quantity", this, _queryContext)); } }
	    public IOrderElement<IOrderOrderContext, IOrderQueryContext> Remarks { get { return _remarks ?? ( _remarks = new OrderElement<IOrderOrderContext, IOrderQueryContext>("Remarks", this, _queryContext)); } }

    }
}
