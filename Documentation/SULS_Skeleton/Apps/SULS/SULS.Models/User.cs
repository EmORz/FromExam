namespace SULS.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        /*•	Has an Id – a string, Primary Key
           •	Has a Username – a string with min length 5 and max length 20 (required)
           •	Has an Email - a string, which holds only valid email (required)
           •	Has a Password – a string with min length 6 and max length 20  - hashed in the database (required)
           */
    }
}