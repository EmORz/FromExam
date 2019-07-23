using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SULS.Data;
using SULS.Models;

namespace SULS.Services
{
    public class SubmissionsServices : ISubmissionsServices
    {
        private readonly SULSContext db;

        public SubmissionsServices(SULSContext db)
        {
            this.db = db;
        }
        public void CreateSubmissions(string code, string userId, string problemId)
        {
            var user = this.db.Users.FirstOrDefault(x => x.Id == userId);
            var problemsTotalPoint = this.db.Problems.Where(x => x.Id == problemId).ToList().Select(x => x.Points).Sum();

            Random rnd = new Random();

            var submission = new Submission()
            {
                Code = code,
                CreatedOn = DateTime.UtcNow,
                AchievedResult = rnd.Next(0, problemsTotalPoint),
                
                
            };
            this.db.Submissions.Add(submission);
            this.db.SaveChanges();
        }
    }
}