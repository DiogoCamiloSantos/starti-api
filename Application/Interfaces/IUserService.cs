namespace StartiApi.Application.Interfaces
{
   public interface IUserService
    {
        string Authenticate(string username, string password, string client);
    }
}
