namespace SULS.Models
{
    public class Problem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Points { get; set; }


        /*•	Has an Id – a string, Primary Key
           •	Has a Name – a string with min length 5 and max length 20 (required)
           •	Has Points– an integer between 50 and 300 (required)
           */
    }
}