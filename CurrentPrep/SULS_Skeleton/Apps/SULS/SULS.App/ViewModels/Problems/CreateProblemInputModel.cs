using SIS.MvcFramework.Attributes.Validation;

namespace SULS.App.ViewModels.Problems
{
    public class CreateProblemInputModel
    {
        [RequiredSis]
        [StringLengthSis(5, 20, errorMessage:"Name must be between 5 and 20")]
        public string Name { get; set; }

        [RequiredSis]
        [RangeSis(50, 300, errorMessage:"Total points must be between 50 and 300")]
        public int Points { get; set; }

        /*•	Has a Name – a string with min length 5 and max length 20 (required)
           •	Has Points– an integer between 50 and 300 (required)
           */
    }
}