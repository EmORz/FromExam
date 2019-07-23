using SULS.Data;
using SULS.Models;

namespace SULS.Services
{
    public class ProblemsServices : IProblemsServices
    {
        private readonly SULSContext db;

        public ProblemsServices(SULSContext db)
        {
            this.db = db;
        }

        
        public void CreateProblem(string name, int totalPoints)
        {
            var problem = new Problem()
            {
                Name = name,
                Points = totalPoints
            };
            this.db.Problems.Add(problem);
            this.db.SaveChanges();
        }
    }
}