using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementDataAccess.DataAccess
{
    public class UserDataAccess
    {
        private static List<User> users = new List<User>
        {
            new User { Username = "testUser", PasswordHash = "testPassword", Email = "testuser@example.com" }
        };
        public void RegisterUser(string username, string password, string email)
        {
            if (GetUserByUsername(username) != null || GetUserByEmail(email) != null)
            {
                throw new RegistrationException("Username or email already exists.");
            }

            string passwordHash = HashPassword(password);
            User newUser = new User { Username = username, PasswordHash = passwordHash, Email = email };

            users.Add(newUser);
        }

        public User GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }

        public User GetUserByEmail(string email)
        {
            return users.FirstOrDefault(u => u.Email == email);
        }

        private string HashPassword(string password)
        {
            return password; 
        }

    }
}
