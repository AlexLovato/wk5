using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wk5cc.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }
        //GET: /Contact
        [HttpGet]
        public ActionResult Contact()
        {
            Models.contact cf = new Models.contact();
            return View(cf);
        }
        //Post: /Contact
        [HttpPost]
        public ActionResult Index(Models.contact cf)
        {
            Models.week5ccEntities db = new Models.week5ccEntities();
            db.contacts.Add(cf);
            db.SaveChanges();
            //Redirect User to Thank you page
            return RedirectToAction("ThankYou");
        }
        //GET: /ThankYou
        public ActionResult ThankYou()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
    }
}
