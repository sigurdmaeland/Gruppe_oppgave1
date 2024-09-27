using Gruppe_oppgave1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gruppe_oppgave1.Controllers
{

    public class MapController : Controller
    {
        private static List<MapModel> positions = new List<MapModel>();

        [HttpGet]
        public IActionResult Map()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Map(Models.MapModel model)
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
