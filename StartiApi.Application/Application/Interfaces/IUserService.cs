namespace StartiApi.Application.Interfaces
{
   public interface IAuthenticationService
    {
        string Authenticate(string username, string password, string client);
    }
}
