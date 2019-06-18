using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Result;

namespace SULS.App.Controllers
{
    public class HomeController : Controller
    {
        // TODO
        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()

        {
            return this.Index();
        }

        public IActionResult Index()
        {
            if (this.IsLoggedIn())
            {
                return this.View("IndexLoggedIn");
            }
            else
            {
                return this.View();
            }
        }
    }
}