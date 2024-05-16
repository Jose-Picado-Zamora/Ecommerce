using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services.MyDbContext;

namespace Services.Users
{
    public class SvUser : IsVUser
    {
        private MyContext _myDbContext = default!;
        public SvAuthor()
        {
            _myDbContext = new MyContext();
        }

        User IsVUser.AddUser(User user)
        {
            throw new NotImplementedException();
        }

        List<User> IsVUser.GetAllUsers()
        {
            throw new NotImplementedException();
        }

        User IsVUser.GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        User IsVUser.RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        User IsVUser.UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
