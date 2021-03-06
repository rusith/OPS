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
    internal class OrderFilterContext : BaseFilterContext, IOrderFilterContext 
    {
		private readonly IOrderQueryContext  _queryContext;
		internal OrderFilterContext(OrderQueryContext context) { _queryContext = context; }
		private INumberFilter<IOrderFilterContext, IOrderQueryContext> _iD;
		private INumberFilter<IOrderFilterContext, IOrderQueryContext> _quantity;
		private IStringFilter<IOrderFilterContext, IOrderQueryContext> _remarks;



		public INumberFilter<IOrderFilterContext, IOrderQueryContext> ID { get { return _iD ?? ( _iD = new NumberFilter<IOrderFilterContext, IOrderQueryContext>("ID", this, _queryContext)); } }

		public INumberFilter<IOrderFilterContext, IOrderQueryContext> Quantity { get { return _quantity ?? ( _quantity = new NumberFilter<IOrderFilterContext, IOrderQueryContext>("Quantity", this, _queryContext)); } }

		public IStringFilter<IOrderFilterContext, IOrderQueryContext> Remarks { get { return _remarks ?? ( _remarks = new StringFilter<IOrderFilterContext, IOrderQueryContext>("Remarks", this, _queryContext)); } }


        public IOrderFilterContext Start
        {
            get
            {
                StartScope();
                return this;
            }
        }
        public IOrderFilterContext End
        {
            get
            {
                EndScope();
                return this;
            }
        }
	}
}

