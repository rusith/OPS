// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using System.Collections.Generic;
namespace OPS.DAL.Infrastructure.Filters.Abstract
{
    /// <summary>
    /// An order context is used to build the order by clause of the target query
    /// </summary>
	public interface IOrderContext
    {
        /// <summary>
        /// Adds an and condition
        /// </summary>
        void And();
        
        /// <summary>
        /// Adds a custom expression
        /// </summary>
        /// <param name="expression">Expression to apply</param>
        void Add(string expression);
        
        /// <summary>
        /// Current expressions as a Queue
        /// </summary>
        Queue<string> GetOrderExpressions();
    }
}


