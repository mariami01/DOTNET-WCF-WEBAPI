using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using PetProject.BL;
using DTO;
using PetProject.Util;

namespace PetProject.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("filter")]
        public IHttpActionResult FilterUsers(string name = null, string lastName = null, string email = null, string roleName = null)
        {
            UserDTO user;
            try
            {
                var token = Request.Headers.Authorization?.Parameter;
                if (string.IsNullOrEmpty(token))
                {
                    return Unauthorized();
                }
                user = AuthValidation.GetAuthenticatedUser(token);
                if (user.RoleName != "Admin")
                {
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var response = UserMangament.FilterUsers(name, lastName, email, roleName);
            if (response.Success)
            {
                return Ok(new
                {
                    response.Message,
                    Users = response.Object
                });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetAllUsers(int pageNumber = 1, int pageSize = 3)
        {
            UserDTO user;
            try
            {
                var token = Request.Headers.Authorization?.Parameter;
                if (string.IsNullOrEmpty(token))
                {
                    return Unauthorized();
                }
                user = AuthValidation.GetAuthenticatedUser(token);
                if (user.RoleName != "Admin")
                {
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var response = UserMangament.GetAllUsers(pageNumber, pageSize);
            if (response.Success)
            {
                return Ok(new
                {
                    response.Message,
                    response.TotalItems,
                    response.PageNumber,
                    response.PageSize,
                    Users = response.Object
                });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
    }
}