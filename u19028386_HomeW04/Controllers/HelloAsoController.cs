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

        [HttpPost]
        public ActionResult JoinUs(string username, string password)
        {
            if(username== "admin" && password == "ppassword")
            {
                 return View("Views");
            }

            ViewBag.Incorrect = "Username and Password Incorrect. Please retry!";
            return View("JoinUs");
            
            
        }



        public ActionResult Messages()
        {
            return View();
        }

        public ActionResult Donations()
        {
            return View();
        }

        public ActionResult BirdView()
        {
            return View();
        }

        public ActionResult PlantView()
        {
            return View();
        }

        public ActionResult MammalView()
        {
            return View();
        }

        public ActionResult FishView()
        {
            List<Fish> fishs = GetFish();
            return View(fishs);
        }

        public ActionResult Views()
        {
            return View();
        }

        public List<Fish> GetFish()
        {
            List<Fish> fishs = new List<Fish>();
            Fish fish1 = new Fish("Blue Tang", "hdf", 4, 4, true);
            Fish fish2 = new Fish("Clown Fish", "hdf", 100, 8, true);
            Fish fish3 = new Fish("Angel Fish", "hdf", 67, 9, false);
            Fish fish4 = new Fish("Gold Fish", "hdf", 800, 4, true);
            Fish fish5 = new Fish("Butterfly Fish", "hdf", 400, 5, true);
            Fish fish6 = new Fish("Pufferfish", "hdf", 49, 12, false);
            Fish fish7 = new Fish("Koi Fish", "hdf", 975, 4, true);
            Fish fish8 = new Fish("male Betta", "hdf", 90, 2, true);
            Fish fish9 = new Fish("Killi Fish", "hdf", 23, 3, false);
            Fish fish10 = new Fish("Gourami", "hdf", 12, 9, true);
            fishs.Add(fish1);
            fishs.Add(fish2);
            fishs.Add(fish3);
            fishs.Add(fish4);
            fishs.Add(fish5);
            fishs.Add(fish6);
            fishs.Add(fish7);
            fishs.Add(fish8);
            fishs.Add(fish9);
            fishs.Add(fish10);
            return fishs;
        }

    

    

    }
}