using System;

namespace OPS.Injection
{
  /// <summary>
  /// The dependency store helps to register dependencies
  /// </summary>
  public interface IDependencyStore
  {
    /// <summary>
    /// Registers a singleton object
    /// </summary>
    /// <returns>this instance</returns>
    IDependencyStore Singleton<TA, TI>();

    /// <summary>
    /// Register a transient object
    /// </summary>
    /// <param name="type"></param>
    /// <param name="type1"></param>
    /// <returns></returns>
    IDependencyStore Transient(Type type, Type type1);
  }
}