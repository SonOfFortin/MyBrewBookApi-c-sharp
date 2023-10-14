using Microsoft.AspNetCore.Mvc;
using MyBrewBookApi.Models;

namespace MyBrewBookApi.Controllers
{
    [ApiController]
    [Route("api/ReceiptsUser")]
    public class ReceiptsUserController : ControllerBase
    {
        private readonly ILogger<ReceiptsUserController> _logger;

        public ReceiptsUserController(ILogger<ReceiptsUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet( Name = "GetReceiptsUser")]
        //public async Task<ActionResult<Receipts>> GetReceiptsUser()
        public IEnumerable<Receipts> GetReceiptsUser()
        {
            //Définition temporaire le temps de monter la BD
            return new Receipts[] { 
                new Receipts {
                    Id = 1,
                    Name = "23 Any Lefte?",
                    AutorId = 3,
                    AutorName = "YeTiLand Brewery",
                    Image = "/image/recipes/logo/Leef.jpg",
                    ClassificationRecipes = 0,
                    StyleId = 0,
                    AutoScaling = true
                },
                new Receipts {
                    Id = 2,
                    Name = "Budweiser Clone",
                    AutorId = 2,
                    AutorName = "TexasTom BeerFactory",
                    Image = "",
                    ClassificationRecipes = 0,
                    StyleId = 1,
                    AutoScaling = true
                },
                new Receipts {
                    Id = 3,
                    Name = "Ryerish Red Ale",
                    AutorId = 1,
                    AutorName = "Matthew",
                    Image = "/image/recipes/logo/RedBeer.jpg",
                    ClassificationRecipes = 0,
                    StyleId = 2,
                    AutoScaling = false
                },
                new Receipts {
                    Id = 4,
                    Name = "Samuel Adams Boston Lager",
                    AutorId = 4,
                    AutorName = "Apocryphy",
                    Image = "",
                    ClassificationRecipes = 0,
                    StyleId = 0,
                    AutoScaling = false
                },
                new Receipts {
                    Id = 5,
                    Name = "23 Any Lefte?",
                    AutorId = 3,
                    AutorName = "YeTiLand Brewery",
                    Image = "/image/recipes/logo/1664.jpg",
                    ClassificationRecipes = 1,
                    StyleId = 0,
                    AutoScaling = true
                },
                new Receipts {
                    Id = 6,
                    Name = "Budweiser Clone",
                    AutorId = 2,
                    AutorName = "TexasTom BeerFactory",
                    Image = "",
                    ClassificationRecipes = 1,
                    StyleId = 1,
                    AutoScaling = true
                },
                new Receipts {
                    Id = 7,
                    Name = "Ryerish Red Ale",
                    AutorId = 1,
                    AutorName = "Matthew",
                    Image = "/image/recipes/logo/SamuelAdams.jpg",
                    ClassificationRecipes = 2,
                    StyleId = 2,
                    AutoScaling = true
                }
            };
        }

        /*// GET: ReceiptsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReceiptsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReceiptsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReceiptsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceiptsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReceiptsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceiptsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReceiptsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
