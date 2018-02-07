using ops.DAL.Infrastructure.Interfaces;

namespace ops.DAL
{
  public class ConnectionProvider : IConnectionStringProvider
  {
    public string GetConnectionString()
    {
      return "Server=localhost;Database=ops;UID=root;Password=password";
    }
  }
}