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

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _svUser.GetAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _svUser.GetUserById(id);
        }
        
        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _svUser.AddUser(user);
        }

    }
}
