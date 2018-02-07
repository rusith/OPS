using System.Collections.Generic;
using OPS.Injection;
using OPS.BL.Modules;

namespace OPS.BL
{
  public class Bootstrapper : IModuleBootstrapper
  {
    public IEnumerable<IModule> GetModules()
    {
      return new List<IModule> { new ServiceModule() };
    }
  }
}