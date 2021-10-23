using APIUsers_MTWDM21Fork.Models;

namespace APIUsers_MTWDM21Fork.Services
{
    public interface IUserService
    {
        User AddUser(User user);

        List<User> GetUsers();

        void UpdateUser(User user);

        void DeleteUser(int ID);

        User GetUser(int ID);
    }
}
