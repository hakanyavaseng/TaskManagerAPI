using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataAccess.Abstract;
using TaskManager.Entities;

namespace TaskManager.DataAccess.Concrete
{
    public class UsersRepository : IUsersRepository
    {

        public Users CreateUser(Users user)
        {
            using(var context = new TaskManagerDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using(var context = new TaskManagerDbContext())
            {
                var deletedUser = GetUserById(id);
                context.Users.Remove(deletedUser);
                context.SaveChanges();
            }
        }

        public List<Users> GetAllUsers()
        {
            using(var context = new TaskManagerDbContext())
            {
                return context.Users.ToList();
            }
        }

        public Users GetUserById(int id)
        {
            using(var context = new TaskManagerDbContext())
            {
                return context.Users.Find(id);
            }
        }

        public bool IsUserExistWithSameUsername(string username)
        {
            using(var context = new TaskManagerDbContext())
            {
                return context.Users.Any(x => x.UserName == username);
            }
        }

        public Users UpdateUser(Users user)
        {
            using(var context = new TaskManagerDbContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
                return user;
            }
        }
    }
}
