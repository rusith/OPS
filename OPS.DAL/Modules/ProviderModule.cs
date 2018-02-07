using OPS.DAL.Providers;
using OPS.Injection;
using OPS.Providers.Data;

namespace OPS.DAL.Modules
{
  public class ProviderModule : IModule
  {
    public void Bootstrap(IDependencyStore store)
    {
      store.Singleton<IOrderProvider, OrderProvider>();
    }
  }
}