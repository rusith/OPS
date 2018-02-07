using System;
using System.Threading.Tasks;
using OPS.Models.Data;
using OPS.Providers.Data;
using OPS.Services.Business;

namespace OPS.BL.Services
{
  public class OrderService : IOrderService
  {
    private readonly IOrderProvider _orderProvider;
    public OrderService(IOrderProvider orderProvider)
    {
      _orderProvider = orderProvider;
    }
    public async Task AddOrderAsync(string remarks, int quantity)
    {
      if (quantity < 1)
        throw new Exception("Quantity should be more than 0");

      await _orderProvider.AddOrderAsync(remarks, quantity);
    }

    public Task<IOrder> GetOrder(int id)
    {
      if (id < 1)
        return null;
      return _orderProvider.GetOrderAsync(id);
    }

    public Task<IOrder> RemoveOrder(int id)
    {
      if (id < 1)
        return null;
      return _orderProvider.DeleteOrderAsync(id);
    }
  }
}