using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectOnUpsell.Models;

namespace ProjectOnUpsell.Controllers
{
    public class HomeController : Controller
    {
        UpsellEntities3 _db = new UpsellEntities3();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            Requirement model = new Requirement();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Requirement model)

        {
            _db.Requirements.Add(model);
            _db.SaveChanges();
            return RedirectToAction("SecondIndex", "Second");
        }
    }
}