using System;
using System.ComponentModel.DataAnnotations;

namespace SULS.Models
{
    public class Problem
    {
        public Problem()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [Range( 50, 300)]
        public int Points { get; set; }
        /*•	Has an Id – a string, Primary Key
           •	Has a Name – a string with min length 5 and max length 20 (required)
           •	Has Points– an integer between 50 and 300 (required)
           */

    }
}