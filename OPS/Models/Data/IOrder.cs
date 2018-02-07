namespace OPS.Models.Data
{

  /// <summary>
  /// An order
  /// </summary>
  public interface IOrder
  {
    string Remarks { get; set; }
    string Quantity { get; set; }
    string ID { get; set; }
  }
}