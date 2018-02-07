using System.Collections.Generic;
using OPS.Injection;
using OPS.DAL.Modules;

namespace OPS.DAL
{
  public class Bootstrapper : IModuleBootstrapper
  {
    public IEnumerable<IModule> GetModules()
    {
      return new List<IModule> { new DataAccessModule(), new ProviderModule() };
    }
  }
}