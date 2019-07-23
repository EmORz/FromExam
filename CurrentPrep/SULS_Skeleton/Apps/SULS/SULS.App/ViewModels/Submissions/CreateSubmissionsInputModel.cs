using SIS.MvcFramework.Attributes.Validation;

namespace SULS.App.ViewModels.Submissions
{
    public class CreateSubmissionsInputModel
    {
        [StringLengthSis(30, 800,"Code must be between 30 and 800 characters lenght!")]
        public string code { get; set; }

        /*min length 30 and max length 800 (required)*/
    }
}