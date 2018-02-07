using OPS.Injection;
using OPS.DAL.Infrastructure.Interfaces;
using OPS.DAL.Infrastructure;
using OPS.DAL;

namespace OPS.DAL.Modules
{
  public class DataAccessModule : IModule
  {
    public void Bootstrap(IDependencyStore store)
    {
      store.Singleton<IConnectionStringProvider, ConnectionProvider>();
      store.Singleton<IDBContext, DBContext>();
    }
  }
}