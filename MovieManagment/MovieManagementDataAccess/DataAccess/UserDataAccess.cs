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
        private List<User> users = new List<User>();

        public void RegisterUser(string username, string password, string email)
        {
            // Check if username or email is already registered
            if (GetUserByUsername(username) != null || GetUserByEmail(email) != null)
            {
                throw new RegistrationException("Username or email already exists.");
            }

            // Hash password and create new user
            string passwordHash = HashPassword(password);
            User newUser = new User { Username = username, PasswordHash = passwordHash, Email = email };

            // Add user to list
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
            // For simplicity, assuming plain text passwords here
            return password; // In practice, you would hash the password securely
        }

    }
}
