using System.Threading.Tasks;
using OPS.Models.Data;

namespace OPS.Providers.Data
{
  /// <summary>
  /// Data access provider for Order
  /// </summary>
  public interface IOrderProvider
  {
    Task AddOrderAsync(string remarks, int quantity);
    Task<IOrder> GetOrderAsync(int id);
    Task<IOrder> DeleteOrderAsync(int id);
  }
}