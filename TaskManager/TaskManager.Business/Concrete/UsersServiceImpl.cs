using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Business.Abstract;
using TaskManager.DataAccess.Abstract;
using TaskManager.DataAccess.Concrete;
using TaskManager.Entities;

namespace TaskManager.Business.Concrete
{
    public class UsersServiceImpl : IUsersService
    {
        private IUsersRepository _usersRepository;

        public UsersServiceImpl()
        {
            _usersRepository = new UsersRepository();
        }
        public Users CreateUser(Users user)
        {
            if (this.IsUserExistWithSameUsername(user.UserName))
                throw new Exception("User already exist with same username");
            else
                return _usersRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            if (id > 0)
                _usersRepository.DeleteUser(id);
            else
                throw new Exception("Id must be greater than 0");

        }

        public List<Users> GetAllUsers()
        {
           return _usersRepository.GetAllUsers();
        }

        public Users GetUserById(int id)
        {
            return _usersRepository.GetUserById(id);
        }

        public bool IsUserExistWithSameUsername(string username)
        {
            return _usersRepository.IsUserExistWithSameUsername(username);
        }

        public Users UpdateUser(Users user)
        {
            return _usersRepository.UpdateUser(user);
        }
    }
}
