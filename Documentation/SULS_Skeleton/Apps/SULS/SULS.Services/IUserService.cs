using SULS.Models;

namespace SULS.Services
{
    public interface IUserService
    {
        //todo add methods
        User GetUserByUsernameAndPassword(string username, string hashPassword);
        void CreateUser(User user);
    }
}