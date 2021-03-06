// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


namespace OPS.DAL.Infrastructure.Filters.Abstract
{

    /// <summary>
    /// An order join is a helper that helps to continue a query in a builder-like pattern
    /// </summary>
    /// <typeparam name="T">Type of the filter context</typeparam>
    /// <typeparam name="TQ">Type of the query context</typeparam>
    public interface IOrderJoin<out T, out TQ> where T : IOrderContext
    {

        /// <summary>
        /// Adds an and condition to the query
        /// </summary>
        T And { get; }
        
        /// <summary>
        /// Completes the order context and returns to the current query context
        /// </summary>
        TQ Order();
    }
}


