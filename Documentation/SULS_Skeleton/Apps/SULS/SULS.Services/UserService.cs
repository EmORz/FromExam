using System.Linq;
using SULS.Data;
using SULS.Models;

namespace SULS.Services
{
    public class UserService : IUserService
    {
        private readonly SULSContext context;

        public UserService(SULSContext sulsContext)
        {
            this.context = sulsContext;
        }


        public User GetUserByUsernameAndPassword(string username, string hashPassword)
        {
            var userS = this.context.Users.SingleOrDefault(user => (user.Username == username || user.Email == username)
                                                              && user.Password == hashPassword);
            return userS;
        }



        public void CreateUser(User user)
        {
            this.context.Users.Add(user);
            this.context.SaveChanges();
        }
    }
}