// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Genie (http://www.github.com/rusith/genie).
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using OPS.DAL.Dapper;
using OPS.DAL.Infrastructure.Collections.Concrete;
using OPS.DAL.Infrastructure.Collections.Abstract;
using OPS.DAL.Infrastructure.Actions.Abstract;
using OPS.DAL.Infrastructure.Actions.Concrete;
using OPS.Models.Data;

namespace OPS.DAL.Infrastructure.Models.Concrete
{



  [Table("`ops`.`Order`")]
  public class Order : BaseModel, IOrder
  {

    private int _iD;
    private int _quantity;
    private string _remarks;







    [Key]
    public int ID { get { return _iD; } set { if (_iD == value) { return; } _iD = value; __Updated("ID"); } }

    public int Quantity { get { return _quantity; } set { if (_quantity == value) { return; } _quantity = value; __Updated("Quantity"); } }

    public string Remarks { get { return _remarks; } set { if (_remarks == value) { return; } _remarks = value; __Updated("Remarks"); } }






    internal override void SetId(object id)
    {

      _iD = (int)id;


    }
  }
}
