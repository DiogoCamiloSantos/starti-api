namespace Starti.Application.Services.interfaces
{
    public interface IAuthenticationService
    {
        string Authenticate(string username, string password, string client);
    }
}
