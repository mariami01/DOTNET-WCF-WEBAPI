using DTO;
using PetProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PetProject.Util
{
    public class AuthValidation
    {
        public static UserDTO GetAuthenticatedUser(string token)
        {
            using (PetModel db = new PetModel())
            {
                UserDTO user = db.Users.Where(u => u.Token == token).Select(u => new UserDTO
                {
                    Id = u.Id,
                    Email = u.Email,
                    LastName = u.LastName,
                    Name = u.Name,
                    RoleId = u.RoleId,
                    RoleName = u.Role.Name,
                    token = token,
                }).FirstOrDefault();

                if (user != null)
                    return user;
                throw new Exception("Invalid token"); 
            }
        }
    }
}