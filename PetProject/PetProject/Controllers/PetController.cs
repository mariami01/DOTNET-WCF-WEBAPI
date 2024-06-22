using DTO;
using PetProject.BL;
using PetProject.Util;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PetProject.Controllers
{

    [RoutePrefix("api/pets")]
    public class PetController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetPets(int pageNumber = 1, int pageSize = 3)
        {
            var response = PetManagement.GetPets(pageNumber, pageSize);
            if (response.Success)
            {
                return Ok(new
                {
                    TotalItems = response.TotalItems,
                    PageNumber = response.PageNumber,
                    PageSize = response.PageSize,
                    Pets = response.Object
                });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddPet([FromBody] Request<PetDTO> request)
        {
            UserDTO user;
            try
            {
                user = AuthValidation.GetAuthenticatedUser(request.Token);
                if (user.RoleName != "Admin")
                {
                    return Unauthorized();
                }
            } catch(Exception ex) {
                return BadRequest(ex.Message);
            }

            Response response = PetManagement.AddPet(request, user);
            if (response.Success)
            {
                return Ok(new { Message = response.Message });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPut]
        [Route("edit/{id}")]
        public IHttpActionResult EditPet(int id, [FromBody] Request<PetDTO> request)
        {
            UserDTO user;
            try
            {
                user = AuthValidation.GetAuthenticatedUser(request.Token);
                if (user.RoleName != "Admin")
                {
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            Response response = PetManagement.EditPet(id, request, user);
            if (response.Success)
            {
                return Ok(new { Message = response.Message });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult DeletePet(int id, [FromBody] Request<PetDTO> request)
        {
            UserDTO user;
            try
            {
                user = AuthValidation.GetAuthenticatedUser(request.Token);
                if (user.RoleName != "Admin")
                {
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            Response response = PetManagement.DeletePet(id, user);
            if (response.Success)
            {
                return Ok(new { Message = response.Message });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpGet]
        [Route("search")]
        public IHttpActionResult SearchPets(string searchTerm)
        {
            var response = PetManagement.SearchPets(searchTerm);
            if (response.Success)
            {
                return Ok(new
                {
                    response.Message,
                    Pets = response.Object
                });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpGet]
        [Route("filter")]
        public IHttpActionResult FilterPets(string name = null, string gender = null, string color = null, string species = null, string location = null)
        {
            var response = PetManagement.FilterPets(name, gender, color, species, location);
            if (response.Success)
            {
                return Ok(new
                {
                    response.Message,
                    Pets = response.Object
                });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
    }
}
