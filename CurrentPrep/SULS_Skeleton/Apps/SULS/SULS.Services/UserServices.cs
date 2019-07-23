﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SULS.Data;
using SULS.Models;

namespace SULS.Services
{
    public class UserServices : IUserServices
    {
        private readonly SULSContext db;

        public UserServices(SULSContext db)
        {
            this.db = db;
        }
        public string Create(string username, string email, string password)
        {
            var user = new User()
            {
                Username = username,
                Email = email,
                Password = HashPassword(password)
            };

            this.db.Users.Add(user);
            this.db.SaveChanges();

            return user.Id;
        }

        public User GetUserOrNull(string username, string password)
        {
            var hashPassword = this.HashPassword(password);
            var user = this.db.Users
                .FirstOrDefault(x =>
                    x.Username == username && x.Password == hashPassword);

            return user;
        }

        public IEnumerable<string> GetUserNames()
        {
            var userNames = this.db.Users.Select(x => x.Username).ToList();
            return userNames;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return Encoding.UTF8.GetString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
    }
}