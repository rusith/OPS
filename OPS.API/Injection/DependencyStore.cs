using Microsoft.Extensions.DependencyInjection;
using OPS.Injection;
using System;

namespace OPS.API.Injection
{
  /// <summary>
  /// A dependency store which uses the .net core injection service
  /// </summary>
  public class DependencyStore : IDependencyStore
  {
    private readonly IServiceCollection _serviceCollection;

    internal DependencyStore(IServiceCollection serviceCollection)
    {
      _serviceCollection = serviceCollection;
    }

    public IDependencyStore Singleton<TA, TI>()
    {
      _serviceCollection.AddSingleton(typeof(TA), typeof(TI));
      return this;
    }

    public IDependencyStore Transient(Type type, Type type1)
    {
      _serviceCollection.AddTransient(type, type1);
      return this;
    }
  }
}