using Microsoft.AspNetCore.Mvc;
using TaskManager.Business.Abstract;
using TaskManager.Business.Concrete;
using TaskManager.Entities;

namespace TaskManager.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersControllers : ControllerBase
    {
        private IUsersService _usersService;



        public UsersControllers()
        {
            _usersService = new UsersServiceImpl();
        }


        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> GetAll()
        {
            return _usersService.GetAllUsers();
        }


        /// <summary>
        /// Gets user by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Users GetById(int id)
        {
            return _usersService.GetUserById(id);
        }


        /// <summary>
        /// Adds new user.
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        public void AddUser(Users user)
        {
            _usersService.CreateUser(user);
        }


        /// <summary>
        /// Updates user.
        /// </summary>
        /// <param name="user"></param>
        [HttpPut]
        public void UpdateUser(Users user)
        {
            _usersService.UpdateUser(user);
        }


        /// <summary>
        /// Deletes user by ID.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            _usersService.DeleteUser(id);
        }









    }
}
