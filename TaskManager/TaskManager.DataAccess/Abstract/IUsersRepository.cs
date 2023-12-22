using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Entities;

namespace TaskManager.DataAccess.Abstract
{
    public interface IUsersRepository
    {
        List<Users> GetAllUsers();
        Users GetUserById(int id);
        Users CreateUser(Users user);
        Users UpdateUser(Users user);
        void DeleteUser(int id);

        bool IsUserExistWithSameUsername(string username);


    }
}
