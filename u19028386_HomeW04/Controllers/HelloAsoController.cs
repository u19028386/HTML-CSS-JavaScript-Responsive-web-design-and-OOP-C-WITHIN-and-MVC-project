using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19028386_HomeW04.Models;

namespace u19028386_HomeW04.Controllers
{
    public class HelloAsoController : Controller
    {
        // GET: HelloAso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WelcomePage()
        {
            return View();
        }

        public ActionResult People()
        {
            return View();
        }

        public ActionResult Purpose()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Places()
        {
            return View();
        }

        public ActionResult TakeAction()
        {
            return View();
        }

        public ActionResult Blogs()
        {
            return View();
        }

        public ActionResult JoinUs()
        {
            return View();
        }

        public ActionResult Messages()
        {
            return View();
        }

        public ActionResult Donations()
        {
            return View();
        }

        public ActionResult Views()
        {
            List<Fish> fishs = GetFish();
            return View(fishs);
        }

        public List<Fish> GetFish()
        {
            List<Fish> fishViewModels = new List<Fish>();
            Fish fish1 = new Fish("hd", "hdf", 4);
            fishViewModels.Add(fish1);
            return fishViewModels;
        }
    }
}