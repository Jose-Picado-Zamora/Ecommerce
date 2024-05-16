using Entities;

namespace Services
{
    public interface IsVUser
    {
        public User AddUser(User user);
        public User UpdateUser(int id, User user);
        public void RemoveUser(int id);
        public User GetUserById(int id);
        public List<User> GetAllUsers();

    }
}
