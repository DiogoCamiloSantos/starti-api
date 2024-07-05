using Microsoft.Extensions.Configuration;
using StartiApi.Application.Interfaces;
using System;
using System.Security.Claims;
using System.Text;

namespace StartiApi.Application.Services
{
    public class AuthenticationService : IAuthenticationService
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
