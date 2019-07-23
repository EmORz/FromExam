using SIS.MvcFramework;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;
using SULS.Services;

namespace SULS.App.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly ISubmissionsServices submissionsServices;

        public SubmissionsController(ISubmissionsServices submissionsServices)
        {
            this.submissionsServices = submissionsServices;
        }

        [Authorize()]
        public IActionResult Create()
        {
            return this.View();

        }
        
    }
}