using System.Threading.Tasks;
using OPS.Models;

namespace OPS.Providers.Data
{
  /// <summary>
  /// Data access provider for Order
  /// </summary>
  public interface IOrderProvider
  {
    Task AddOrderAsync(IOrder order);
    Task<IOrder> GetOrderAsync(int id);
    Task<IOrder> DeleteOrderAsync(int id);
  }
}