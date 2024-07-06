public interface IAuthenticationService
{
    string GenerateToken(string username, string client);
}