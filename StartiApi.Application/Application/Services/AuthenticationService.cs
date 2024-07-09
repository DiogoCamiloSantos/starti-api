using Microsoft.Extensions.Configuration;
using Starti.Application.Application.Services.interfaces;
using System;
using System.Security.Claims;
using System.Text;

namespace StartiApi.Application.Services
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
