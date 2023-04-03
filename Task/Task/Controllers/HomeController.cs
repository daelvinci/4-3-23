using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }

}
