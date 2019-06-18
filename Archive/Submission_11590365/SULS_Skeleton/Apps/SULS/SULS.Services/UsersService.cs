using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SULS.Data;
using SULS.Models;

namespace SULS.Services
{
    public class UsersService : IUsersService
    {
        private readonly SULSContext db;

        public UsersService(SULSContext db)
        {
            this.db = db;
        }
        public User CreateUser(User userX)
        {
            userX = this.db.Users.Add(userX).Entity;
            this.db.SaveChanges();

            return userX;
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            var data = this.db.Users.SingleOrDefault(user => (user.Username == username || user.Email == username)
                                                             && user.Password == password);
            return data;
        }
        //
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return Encoding.UTF8.GetString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
    }
}