using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;
using SULS.App.ViewModels.Problems;
using SULS.Services;

namespace SULS.App.Controllers
{
    public class ProblemsController: Controller
    {
        private readonly ProblemsServices problemsServices;

        public ProblemsController(ProblemsServices problemsServices)
        {
            this.problemsServices = problemsServices;
        }
        [Authorize()]
        public IActionResult Create()
        {
            return this.View();
        }
        [Authorize()]
        public IActionResult Details()
        {
            return this.View();
        }


        [Authorize()]
        [HttpPost]
        public IActionResult Create(CreateProblemInputModel createProblem)
        {
            if (!ModelState.IsValid)
            {
                return this.Redirect("/");
            }

            this.problemsServices.CreateProblem(createProblem.Name, createProblem.Points);
        
            return this.Redirect("/");
        }
    }
}