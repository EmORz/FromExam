using SULS.Models;

namespace SULS.Services
{
    public interface IUsersService
    {
        User CreateUser(User userX);

        User GetUserByUsernameAndPassword(string username, string password);
    }
}