namespace Starti.Application.Application.Services.interfaces
{
    public interface IAuthenticationService
    {
        string Authenticate(string username, string password, string client);
    }
}
