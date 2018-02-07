using System.Threading.Tasks;
using OPS.Models.Data;

namespace OPS.Services.Business
{
  public interface IOrderService
  {
    Task AddOrderAsync(string remarks, int quantity);
    Task<IOrder> GetOrder(int id);
    Task<IOrder> RemoveOrder(int id);
  }
}