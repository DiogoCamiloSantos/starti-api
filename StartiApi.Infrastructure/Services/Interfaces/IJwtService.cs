public interface IJwtService
{
    string GenerateToken(string username, string client);
}