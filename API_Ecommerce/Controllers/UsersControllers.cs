using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Users;

namespace API_Ecommerce.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IsVUser _svUser;
        public UsersController(IsVUser svUser)
        {
            _svUser = svUser;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _svUser.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _svUser.GetUserById(id);
        }

        [HttpPost]
        public void Post([FromBody] UserRequest userRequest)
        {
            User user = new User()
            {
                name = userRequest.name,
                password = userRequest.password,
                email = userRequest.email,
                address = userRequest.address,
            };
            _svUser.AddUser(user);
        }
    }
}
