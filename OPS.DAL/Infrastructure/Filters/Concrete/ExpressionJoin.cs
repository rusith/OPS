// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using OPS.DAL.Infrastructure.Filters.Abstract;

namespace OPS.DAL.Infrastructure.Filters.Concrete
{
    public class ExpressionJoin<T, TQ> : IExpressionJoin<T, TQ> where T : IFilterContext
    {
        private readonly T _t;
        private readonly TQ _q;

        internal ExpressionJoin(T t, TQ q)
        {
            _t = t;
            _q = q;
        }

        public T And
        {
            get
            {
                _t.And();
                return _t;
            }
        }

        public T Or
        {
            get
            {
                _t.Or();
                return _t;
            }
        }

        public IExpressionJoin<T, TQ> Start
        {
            get
            {

                _t.StartScope();
                return this;
            }
        }

        public IExpressionJoin<T, TQ> End
        {
            get
            {
                _t.EndScope();
                return this;
            }
        }

        public TQ Filter()
        {
            return _q;
        }
    }
}

