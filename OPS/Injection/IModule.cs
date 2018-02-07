namespace OPS.Injection
{
  /// <summary>
  /// An app module
  /// </summary>
  public interface IModule
  {
    /// <summary>
    /// Bootstrap the module
    /// </summary>
    /// <param name="store"></param>
    void Bootstrap(IDependencyStore store);
  }
}