using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.Users
{
    public class SvUser : IsVUser
    {
        private MyContext _myDbContext = default!;
        public SvUser()
        {
            _myDbContext = new MyContext();
        }
        #region Reads
        public List<User> GetAllUsers()
        {
            return _myDbContext.Users.Include(x => x.Bills).ToList();
        }

        public User GetUserById(int id)
        {       //_myDbContext.Users.Find(id)
            return _myDbContext.Users.Include(x => x.Bills).SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region Writes
        public User AddUser(User user)
        {

            _myDbContext.Users.Add(user);
            _myDbContext.SaveChanges();

            return user;
        }
        public void RemoveUser(int id)
        {
            User deleteUser = _myDbContext.Users.Find(id);

            if (deleteUser is not null)
            {
                _myDbContext.Users.Remove(deleteUser);
                _myDbContext.SaveChanges();
            }
        }
        public User UpdateUser(int id, User newUser)
        {
            User updateUser = _myDbContext.Users.Find(id);

            if (updateUser is not null)
            {
                updateUser.name = newUser.name;
                updateUser.email = newUser.email;
                updateUser.password = newUser.password;
                updateUser.address = newUser.address;

                _myDbContext.Users.Update(updateUser);
                _myDbContext.SaveChanges();
            }

            return updateUser;

        }

        #endregion
    }
}
