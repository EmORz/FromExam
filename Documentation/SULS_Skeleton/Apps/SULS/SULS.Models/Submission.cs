using System;

namespace SULS.Models
{
    public class Submission
    {
        public Submission()
        {
            this.Problem = new Problem();
            this.User = new User();
        }
        public string Id { get; set; }

        public string Code { get; set; }

        public int AchievedResult { get; set; }

        public DateTime CreatedOn { get; set; }

        public Problem Problem { get; set; }

        public User User { get; set; }

        /*•	Has an Id – a string, Primary Key
•	Has Code – a string with min length 30 and max length 800 (required)
•	Has Achieved Result – an integer between 0 and 300 (required)
•	Has a Created On – a DateTime object (required)
•	Has Problem – a Problem object
•	Has User – a User object
*/
    }
}