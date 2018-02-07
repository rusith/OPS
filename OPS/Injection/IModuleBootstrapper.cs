using System.Collections.Generic;

namespace OPS.Injection
{
  /// <summary>
  /// Helps to bootstrap a module of an application by aggregating list of modules of an assembly
  /// </summary>
  public interface IModuleBootstrapper
  {
    /// <summary>
    /// Get all the sub modules
    /// </summary>
    IEnumerable<IModule> GetModules();
  }
}