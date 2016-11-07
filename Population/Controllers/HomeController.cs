using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DatabaseDAL.Entity;
using DatabaseDAL.Memory;
using MongoDB.Bson;

namespace Population.Controllers
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