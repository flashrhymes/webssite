using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websites.model1;

namespace websites.Controllers
{
    public class HomeController : Controller
    {
        websiteEntities db = new websiteEntities();
        public ActionResult Index()
        {
            ViewBag.Post = db.Post.ToList();
            ViewBag.setting = db.Settings.First();
            ViewBag.Home = db.Home.First();
            return View();
        }
        public ActionResult About()
        {
            ViewBag.setting = db.Settings.First();
            ViewBag.About = db.About.First();
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.setting = db.Settings.First();
            ViewBag.Contact = db.Contact.First();
            return View();
        }
        public ActionResult Post(int id)
        {
            Post pst = db.Post.Find(id);
            ViewBag.Post = pst;
            ViewBag.setting = db.Settings.First();
            
            return View();
        }
    }
}