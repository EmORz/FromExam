using System.Collections.Generic;
using SULS.Models;

namespace SULS.Services
{
    public interface IUserServices
    {
        string Create(string username, string email, string password);

        User GetUserOrNull(string username, string password);

        IEnumerable<string> GetUserNames();
    }
}