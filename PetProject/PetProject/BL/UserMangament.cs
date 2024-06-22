using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using DTO;
using PetProject.Models;

namespace PetProject.BL
{
    public class UserMangament
    {
        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private static string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }

        public static Response Register(Request<UserDTO> request)
        {
            try
            {
                UserDTO userDto = request.Object;
                userDto.Password = HashPassword(userDto.Password);

                using (PetModel db = new PetModel())
                {
                    User user = new User
                    {
                        Name = userDto.Name,
                        LastName = userDto.LastName,
                        Email = userDto.Email,
                        CreatedTime = DateTime.Now,
                        PasswordHash = userDto.Password,
                        RoleId = userDto.RoleId
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                return new Response { Success = true, Message = "User registered successfully" };
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = "Error registering user", Errors = new Dictionary<string, string> { { "Exception", ex.Message } } };
            }
        }

        public static Response Login(Request<UserDTO> request)
        {
            try
            {
                UserDTO userDto = request.Object;
                string hashedPassword = HashPassword(userDto.Password);

                using (PetModel db = new PetModel())
                {
                    User user = db.Users.FirstOrDefault(u => u.Email == userDto.Email && u.PasswordHash == hashedPassword);
                    if (user == null)
                    {
                        return new Response { Success = false, Message = "Invalid email or password" };
                    }

                    string token = GenerateToken();
                    user.Token = token;
                   // user.TokenExpiry = DateTime.UtcNow.AddHours(1); 
                    db.SaveChanges();

                    return new Response { Success = true, Message = "Login successful", Token = token, UserId = user.Id };
                }
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = "Error logging in", Errors = new Dictionary<string, string> { { "Exception", ex.Message } } };
            }
        }

        public static Response GetAllUsers(int pageNumber = 1, int pageSize = 3)
        {
            try
            {
                using (PetModel db = new PetModel())
                {
                    var query = db.Users.Select(u => new UserDTO
                    {
                        Id = u.Id,
                        Name = u.Name,
                        LastName = u.LastName,
                        Email = u.Email,
                        RoleId = u.RoleId,
                        RoleName = u.Role.Name,
                        token = u.Token
                    });

                    int totalItems = query.Count();
                    List<UserDTO> users = query
                        .OrderBy(u => u.Name)
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    return new Response
                    {
                        Success = true,
                        Message = "Users retrieved successfully",
                        Object = users,
                        TotalItems = totalItems,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    };
                }
            }
            catch (Exception e)
            {
                return new Response
                {
                    Success = false,
                    Message = e.Message
                };
            }
        }

        public static Response FilterUsers(string name, string lastName, string email, string roleName)
        {
            try
            {
                using (PetModel db = new PetModel())
                {
                    var query = db.Users.AsQueryable();

                    if (!string.IsNullOrEmpty(name))
                    {
                        query = query.Where(u => u.Name.Contains(name));
                    }
                    if (!string.IsNullOrEmpty(lastName))
                    {
                        query = query.Where(u => u.LastName.Contains(lastName));
                    }
                    if (!string.IsNullOrEmpty(email))
                    {
                        query = query.Where(u => u.Email.Contains(email));
                    }
                    if (!string.IsNullOrEmpty(roleName))
                    {
                        query = query.Where(u => u.Role.Name.Contains(roleName));
                    }

                    var users = query.Select(u => new UserDTO
                    {
                        Id = u.Id,
                        Name = u.Name,
                        LastName = u.LastName,
                        Email = u.Email,
                        RoleId = u.RoleId,
                        RoleName = u.Role.Name,
                        token = u.Token
                    }).ToList();

                    return new Response
                    {
                        Success = true,
                        Message = "Users filtered successfully",
                        Object = users
                    };
                }
            }
            catch (Exception e)
            {
                return new Response
                {
                    Success = false,
                    Message = e.Message
                };
            }
        }
    }
}