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


        [HttpGet]
        public ActionResult AddFish()
        {
            return View();
        }

        public ActionResult AddPlant()
        {
            return View();
        }

        public ActionResult AddMammal()
        {
            return View();
        }

        public ActionResult AddBird()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FishView()
        {
            
            return View(fishs);
        }

        public ActionResult BirdView()
        {

            return View(birds);
        }

        public ActionResult PlantView()
        {

            return View(plants);
        }

        public ActionResult MammalView()
        {

            return View(mammals);
        }

        [HttpPost]
        public ActionResult AddPlant(string name, string country, int amount, int maxweight, int maxheight)
        {

            Plant newP = new Plant(name, country, Convert.ToInt32(amount), Convert.ToInt32(maxweight), Convert.ToInt32(maxheight));

            naturals.Add(newP);
            plants.Add(newP);
            return RedirectToAction("PlantView");
        }

        [HttpPost]
        public ActionResult AddMammal(string name, string country, int amount, int maxweight, string type)
        {

            Mammal newM = new Mammal(name, country, Convert.ToInt32(amount), Convert.ToInt32(maxweight), type);

            naturals.Add(newM);
            mammals.Add(newM);
            return RedirectToAction("MammalView");
        }

        [HttpPost]
        public ActionResult AddBird(string name, string country, int amount, int maxweight, int speed)
        {

            Bird newB = new Bird(name, country, Convert.ToInt32(amount), Convert.ToInt32(maxweight), Convert.ToInt32(speed));

            naturals.Add(newB);
            birds.Add(newB);
            return RedirectToAction("BirdView");
        }


        public static List<Fish> fishs = new List<Fish>();
        public static List<NaturalResourcecs> naturals = new List<NaturalResourcecs>();
        public static List<Plant> plants = new List<Plant>();
        public static List<Mammal> mammals = new List<Mammal>();
        public static List<Bird> birds = new List<Bird>();


        [HttpPost]
        public ActionResult AddFish(string name, string country, int amount, int maxweight, bool seawater)
        {
            
            Fish newF = new Fish(name, country, Convert.ToInt32(amount), Convert.ToInt32(maxweight), Convert.ToBoolean(seawater));

            naturals.Add(newF);
            fishs.Add(newF);
            return RedirectToAction("FishView");
        }

        public ActionResult DeleteFish()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DeleteFish(string name, string country)
        {
            for (int i = fishs.Count - 1; i >= 0; i--)
            {
                if (fishs[i].Name == name && fishs[i].Country == country)
                {
                    fishs.RemoveAt(i);
                }
            }
            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals.RemoveAt(i);
                }
            }

            return RedirectToAction("FishView");
        }

        public ActionResult DeleteBird()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DeleteBird(string name, string country)
        {
            for (int i = birds.Count - 1; i >= 0; i--)
            {
                if (birds[i].Name == name && birds[i].Country == country)
                {
                    birds.RemoveAt(i);
                }
            }
            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals.RemoveAt(i);
                }
            }

            return RedirectToAction("BirdView");
        }

        public ActionResult DeleteMammal()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DeleteMammal(string name, string country)
        {
            for (int i = mammals.Count - 1; i >= 0; i--)
            {
                if (mammals[i].Name == name && mammals[i].Country == country)
                {
                    mammals.RemoveAt(i);
                }
            }
            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals.RemoveAt(i);
                }
            }

            return RedirectToAction("MammalView");
        }

        public ActionResult DeletePlant()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DeletePlant(string name, string country)
        {
            for (int i = plants.Count - 1; i >= 0; i--)
            {
                if (plants[i].Name == name && plants[i].Country == country)
                {
                    plants.RemoveAt(i);
                }
            }
            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals.RemoveAt(i);
                }
            }

            return RedirectToAction("PlantView");
        }

        public ActionResult UpdateFish()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UpdateFish(string name, string country ,int amount, int maxweight, bool seawater)
        {
            for (int i = fishs.Count - 1; i >= 0; i--)
            {
                if (fishs[i].Name == name && fishs[i].Country == country)
                {
                    fishs[i].Name = name;
                    fishs[i].SeaWater = Convert.ToBoolean(seawater);
                    fishs[i].Country = country;
                    fishs[i].Amount = Convert.ToInt32(amount);
                    fishs[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals[i].Name = name;
                    naturals[i].Country = country;
                    naturals[i].Amount = Convert.ToInt32(amount);
                    naturals[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            return RedirectToAction("FishView");
        }

        public ActionResult UpdateBird()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UpdateBird(string name, string country, int amount, int maxweight, int speed)
        {
            for (int i = birds.Count - 1; i >= 0; i--)
            {
                if (birds[i].Name == name && birds[i].Country == country)
                {
                    birds[i].Name = name;
                    birds[i].Speed = Convert.ToInt32(speed);
                    birds[i].Country = country;
                    birds[i].Amount = Convert.ToInt32(amount);
                    birds[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals[i].Name = name;
                    naturals[i].Country = country;
                    naturals[i].Amount = Convert.ToInt32(amount);
                    naturals[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            return RedirectToAction("BirdView");
        }

        public ActionResult UpdatePlant()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UpdatePlant(string name, string country, int amount, int maxweight, int maxheight)
        {
            for (int i = plants.Count - 1; i >= 0; i--)
            {
                if (plants[i].Name == name && plants[i].Country == country)
                {
                    plants[i].Name = name;
                    plants[i].MaxHeight = Convert.ToInt32(maxheight);
                    plants[i].Country = country;
                    plants[i].Amount = Convert.ToInt32(amount);
                    plants[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals[i].Name = name;
                    naturals[i].Country = country;
                    naturals[i].Amount = Convert.ToInt32(amount);
                    naturals[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            return RedirectToAction("PlantView");
        }

        public ActionResult UpdateMammal()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UpdateMammal(string name, string country, int amount, int maxweight, string type)
        {
            for (int i = mammals.Count - 1; i >= 0; i--)
            {
                if (mammals[i].Name == name && mammals[i].Country == country)
                {
                    mammals[i].Name = name;
                    mammals[i].Type = type;
                    mammals[i].Country = country;
                    mammals[i].Amount = Convert.ToInt32(amount);
                    mammals[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            for (int i = naturals.Count - 1; i >= 0; i--)
            {
                if (naturals[i].Name == name && naturals[i].Country == country)
                {
                    naturals[i].Name = name;
                    naturals[i].Country = country;
                    naturals[i].Amount = Convert.ToInt32(amount);
                    naturals[i].MaxWeight = Convert.ToInt32(maxweight);
                }
            }

            return RedirectToAction("MammalView");
        }

        public ActionResult People()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult TakeAction()
        {
            return View(naturals);
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
            if (username == "admin" && password == "ppassword")
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

        public ActionResult Views()
        {
            return View();
        }      

    }
 }
