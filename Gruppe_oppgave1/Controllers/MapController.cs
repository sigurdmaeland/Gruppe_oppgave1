using Microsoft.AspNetCore.Mvc;

namespace Gruppe_oppgave1.Controllers
{
    public class MapController : Controller
    {
        [HttpGet]
        public IActionResult Map()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Map(MapModel model)
        {
            if (ModelState.IsValid)
            {
                positions.Add(model);
                return View("MapModel", positions);
            }
            return View(model);
        }
    }

}
