using System.Threading.Tasks;
using OPS.DAL.Infrastructure.Interfaces;
using OPS.DAL.Infrastructure.Models.Concrete;
using OPS.Models.Data;
using OPS.Providers.Data;

namespace OPS.DAL.Providers
{
  public class OrderProvider : IOrderProvider
  {
    private readonly IDBContext _context;

    public OrderProvider(IDBContext context)
    {
      _context = context;
    }

    public async Task AddOrderAsync(IOrder order)
    {
      var unit = _context.Unit();

      unit.OrderRepository.Add(new Order() { Quantity = order.Quantity, Remarks = order.Remarks });
      await unit.CommitAsync();
    }

    public async Task<IOrder> DeleteOrderAsync(int id)
    {
      var unit = _context.Unit();

      var order = await unit.OrderRepository.GetByKeyAsync(id);
      if (order == null)
        return null;
      unit.OrderRepository.Remove(order);
      await unit.CommitAsync();
      return order;
    }

    public async Task<IOrder> GetOrderAsync(int id)
    {
      return await _context.Unit().OrderRepository.GetByKeyAsync(id);
    }
  }
}