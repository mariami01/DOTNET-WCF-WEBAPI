using MovieManagementDataAccess.DataAccess;
using MovieManagementDataAccess.Models;
using MovieManagementService.Contracts;
using MovieManagementService.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieManagementService.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserDataAccess userDataAccess = new UserDataAccess();

        public string AuthenticateUser(string username, string password)
        {
            User user = userDataAccess.GetUserByUsername(username);

            if (user != null && VerifyPassword(password, user.PasswordHash))
            {
                return GenerateAuthToken(user);
            }

            throw new AuthenticationException("Invalid username or password.");
        }

        public string AuthenticateUserXml(string username, string password)
        {
            return AuthenticateUser(username, password);
        }

        private string GenerateAuthToken(User user)
        {
            return $"{user.Username}-{user.Email}";
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            return password == hashedPassword;
        }
    }
}
