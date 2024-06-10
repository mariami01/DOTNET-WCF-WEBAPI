using MovieManagementDataAccess.DataAccess;
using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Web;

namespace MovieManagementService.Services
{
    public class AuthenticationService
    {
        private UserDataAccess userDataAccess = new UserDataAccess();

        public string AuthenticateUser(string username, string password)
        {
            // Retrieve user from data access layer
            User user = userDataAccess.GetUserByUsername(username);

            // Verify user credentials
            if (user != null && VerifyPassword(password, user.PasswordHash))
            {
                // Return authentication token
                return GenerateAuthToken(user);
            }

            // Authentication failed
            throw new AuthenticationException("Invalid username or password.");
        }

        private string GenerateAuthToken(User user)
        {
            // For simplicity, generating a simple authentication token
            return $"{user.Username}-{user.Email}"; // In practice, use a secure token mechanism (e.g., JWT)
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            // For simplicity, assuming plain text passwords here
            return password == hashedPassword;
        }
    }
}