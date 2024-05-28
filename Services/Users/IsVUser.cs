using Entities;

namespace Services
{
    public interface IsVUser
    {
        public User AddUser(User user);
        public User GetUserById(int id);
        public List<User> GetAllUsers();

    }
}
