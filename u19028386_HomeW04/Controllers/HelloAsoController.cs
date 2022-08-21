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
            List<Bird> birds = GetBird();
            return View(birds);
        }

        public List<Bird> GetBird()
        {
            List<Bird> birds = new List<Bird>();
            Bird bird1 = new Bird("Kakapo", "South Africa", 4, 12, 2);
            Bird bird2 = new Bird("Fruit Dove", "Swaziland", 100, 9, 1);
            Bird bird3 = new Bird("Grebe", "Congo", 67, 1, 1);
            Bird bird4 = new Bird("Snowy Owl", "Nigeria", 800, 2, 1);
            Bird bird5 = new Bird("Currasow", "Cuba", 400, 1, 1);
            Bird bird6 = new Bird("Condor", "Canada", 49, 6, 2);
            Bird bird7 = new Bird("Kiwi", "New Zealand", 975, 3, 1);
            Bird bird8 = new Bird("Grey Parrot", "Lesotho", 90, 7, 3);
            Bird bird9 = new Bird("Bald Ibis", "Russia", 23, 9, 1);
            Bird bird10 = new Bird("Lorikeets", "Mozambique", 12, 6, 1);
            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(bird3);
            birds.Add(bird4);
            birds.Add(bird5);
            birds.Add(bird6);
            birds.Add(bird7);
            birds.Add(bird8);
            birds.Add(bird9);
            birds.Add(bird10);
            return birds;
        }


        public ActionResult PlantView()
        {
            List<Plant> plants = GetPlant();
            return View(plants);
        }

        public List<Plant> GetPlant()
        {
            List<Plant> plants = new List<Plant>();
            Plant plant1 = new Plant("Prickly Cica", "South Africa", 4, 12, 2);
            Plant plant2 = new Plant("Micholitzii", "Swaziland", 100, 9, 5);
            Plant plant3 = new Plant("Preauxiana", "Congo", 67, 1, 2);
            Plant plant4 = new Plant("Anegadensis", "Nigeria", 800, 2, 3);
            Plant plant5 = new Plant("Anglica", "Cuba", 400, 1, 6);
            Plant plant6 = new Plant("Titanum", "Canada", 49, 6, 6);
            Plant plant7 = new Plant("Muscipula", "New Zealand", 975, 3, 7);
            Plant plant8 = new Plant("Revoluta", "Lesotho", 90, 7, 1);
            Plant plant9 = new Plant("Cycas", "Russia", 23, 9, 9);
            Plant plant10 = new Plant("Dionaea", "Mozambique", 12, 6, 4);
            plants.Add(plant1);
            plants.Add(plant2);
            plants.Add(plant3);
            plants.Add(plant4);
            plants.Add(plant5);
            plants.Add(plant6);
            plants.Add(plant7);
            plants.Add(plant8);
            plants.Add(plant9);
            plants.Add(plant10);
            return plants;
        }


        public ActionResult MammalView()
        {
            List<Mammal> mammals = GetMammal();
            return View(mammals);
        }

        public List<Mammal> GetMammal()
        {
            List<Mammal> mammals = new List<Mammal>();
            Mammal mammal1 = new Mammal("Black Rhino", "South Africa", 4, 200, "Herbivore");
            Mammal mammal2 = new Mammal("Amur Leopard", "Swaziland", 100, 90, "Carnivore");
            Mammal mammal3 = new Mammal("River Gorilla", "Congo", 67, 150, "Herbivore");
            Mammal mammal4 = new Mammal("Javan Rhino", "Nigeria", 800, 200, "Herbivore");
            Mammal mammal5 = new Mammal("Sunda Tiger", "Cuba", 400, 110, "Carnivore");
            Mammal mammal6 = new Mammal("Lowland Gorilla", "Canada", 49, 160, "Herbivore");
            Mammal mammal7 = new Mammal("Asian Elephant", "New Zealand", 975, 350, "Herbivore");
            Mammal mammal8 = new Mammal("Bonobo", "Lesotho", 90, 78, "Carnivore");
            Mammal mammal9 = new Mammal("Chimpanzee", "Russia", 23, 90, "Herbivore");
            Mammal mammal10 = new Mammal("Green Turtle", "Mozambique", 12, 60, "Herbivore");
            mammals.Add(mammal1);
            mammals.Add(mammal2);
            mammals.Add(mammal3);
            mammals.Add(mammal4);
            mammals.Add(mammal5);
            mammals.Add(mammal6);
            mammals.Add(mammal7);
            mammals.Add(mammal8);
            mammals.Add(mammal9);
            mammals.Add(mammal10);
            return mammals;
        }

        [HttpGet]
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
            Fish fish1 = new Fish("Blue Tang", "South Africa", 4, 4, true);
            Fish fish2 = new Fish("Clown Fish", "Swaziland", 100, 8, true);
            Fish fish3 = new Fish("Angel Fish", "Congo", 67, 9, false);
            Fish fish4 = new Fish("Gold Fish", "Nigeria", 800, 4, true);
            Fish fish5 = new Fish("Butterfly Fish", "Cuba", 400, 5, true);
            Fish fish6 = new Fish("Pufferfish", "Canada", 49, 12, false);
            Fish fish7 = new Fish("Koi Fish", "New Zealand", 975, 4, true);
            Fish fish8 = new Fish("Betta Fish", "Lesotho", 90, 2, true);
            Fish fish9 = new Fish("Killi Fish", "Russia", 23, 3, false);
            Fish fish10 = new Fish("Gourami Fish", "Mozambique", 12, 9, true);
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

      

        [HttpPost]
        public ActionResult FishView(string name, string country, int amount, int maxweight, bool seawater)
        {

            List<Fish> fishs = new List<Fish>();
            Fish fish11 = new Fish(name,country, Convert.ToInt32(amount), Convert.ToInt32(maxweight),Convert.ToBoolean(seawater));
            fishs.Add(fish11);

            return View();

            }

        }





 }
