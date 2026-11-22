using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UkwSzop.DAL;

namespace UkwSzop.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await db.Categories.ToListAsync();

            return View("_Menu", categories);
        }
    }
}
