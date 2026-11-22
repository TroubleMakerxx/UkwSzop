using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UkwSzop.DAL;

namespace UkwSzop.Controllers
{
      public class FilmsController : Controller
        {
            FilmsContext db;

            public FilmsController(FilmsContext db)
            {
                this.db = db;
            }

            public IActionResult FilmsList(string categoryName)
            {
                var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();

                var films = category.Films.ToList();

                return View(films);
            }

            public IActionResult Index()
            {
                return View();
            }
        }
}
