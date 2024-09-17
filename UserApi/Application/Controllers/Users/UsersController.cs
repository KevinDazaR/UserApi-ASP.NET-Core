using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UserApi.Services.Repository; 
using UserApi.Services.Interface; 

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            if(!ModelState.IsValid)
            {
                Utils.Exceptions.StatusError.CreateBadRequest();
            }

            try
            {
                return Ok(_userRepository.GetAllUsers()); // Corregido a _usersRepository
            }
            catch (Exception)
            {
                var problemDetails = Utils.Exceptions.StatusError.CreateServerError();
                return StatusCode(StatusCodes.Status500InternalServerError, problemDetails);
                throw;
            }
        }
    }
}
