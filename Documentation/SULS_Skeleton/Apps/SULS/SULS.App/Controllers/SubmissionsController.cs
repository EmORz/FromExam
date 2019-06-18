using SIS.MvcFramework;
using SIS.MvcFramework.Result;

namespace SULS.App.Controllers
{
    public class SubmissionsController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }
    }
}