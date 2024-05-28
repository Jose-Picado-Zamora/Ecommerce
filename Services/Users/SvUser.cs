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
        #endregion
    }
}
