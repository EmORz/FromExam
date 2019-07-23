using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SULS.Models
{
    public class Submission
    {
        public Submission()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Problems = new List<Problem>();
            this.Users = new List<User>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(800)]
        public string Code { get; set; }

        [Required]
        [Range(0, 300)]
        public int AchievedResult { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public string ProblemsId { get; set; }
        public Problem Problem { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<User> Users { get; set; }






        /*•	Has an Id – a string, Primary Key
           •	Has Code – a string with min length 30 and max length 800 (required)
           •	Has Achieved Result – an integer between 0 and 300 (required)
           •	Has a Created On – a DateTime object (required)
           •	Has Problem – a Problem object
           •	Has User – a User object
           */
    }
}