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
            fishViewModels.Add(fish1);
            fishViewModels.Add(fish2);
            fishViewModels.Add(fish3);
            fishViewModels.Add(fish4);
            fishViewModels.Add(fish5);
            fishViewModels.Add(fish6);
            fishViewModels.Add(fish7);
            fishViewModels.Add(fish8);
            fishViewModels.Add(fish9);
            fishViewModels.Add(fish10);
            return fishViewModels;
        }

    

    

    }
}