using OPS.DAL.Infrastructure.Interfaces;

namespace OPS.DAL
{
  public class ConnectionProvider : IConnectionStringProvider
  {
    public string GetConnectionString()
    {
      return "Server=localhost;Database=ops;UID=root;Password=password";
    }
  }
}