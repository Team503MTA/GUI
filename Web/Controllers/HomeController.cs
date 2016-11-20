using System.Collections.Generic;
using System.Web.Mvc;
using DatabaseManager.Entity;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
    }
}