using Microsoft.Extensions.Configuration;
using Starti.Application.Services.interfaces;

namespace Starti.Application.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _config;

        public AuthenticationService(IConfiguration config)
        {
            _config = config;
        }

        public string Authenticate(string username, string password, string client)
        {
            throw new NotImplementedException();
        }
    }
}
