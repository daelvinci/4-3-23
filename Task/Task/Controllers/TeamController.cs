using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Task.Models;

namespace Task.Controllers
{
    public class TeamController : Controller
    {
        private readonly DataContext _context;

        public TeamController(DataContext context)
        {
            _context = context;
            
        }
        public ActionResult Index()
        {
            var data = _context.Members.ToList();
            return View(data);
        }
        public ActionResult Detail(int id)
        {
            var member = _context.Members.Find(id);
            return View(member);
        }


    }
}
