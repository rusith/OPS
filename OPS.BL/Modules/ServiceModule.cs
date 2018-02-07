using OPS.Injection;
using OPS.Services.Business;
using OPS.BL.Services;

namespace OPS.BL.Modules
{
  public class ServiceModule : IModule
  {
    public void Bootstrap(IDependencyStore store)
    {
      store.Singleton<IOrderService, OrderService>();
    }
  }
}