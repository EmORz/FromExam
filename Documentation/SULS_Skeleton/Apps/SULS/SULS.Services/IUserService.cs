using SULS.Models;

namespace SULS.Services
{
    public interface IUserService
    {
        User GetUserByUsernameAndPassword(string username, string hashPassword);
        void CreateUser(User user);
    }
}