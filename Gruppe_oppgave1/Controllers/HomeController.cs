using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Gruppe_oppgave1.Models;

namespace Gruppe_oppgave1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static List<MapModel> positions = new List<MapModel>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
   
    [HttpGet]
    public IActionResult Map()
    {
        return View(); // Retunerer en visning som viser et skjema hvor brukeren kan legge inn kartdata
    }

    [HttpPost]
    public IActionResult Map(MapModel model)
    {
        // Sjekker om modellen er gyldig i henhold til valideringsreglene i MapModel.cs
        if (ModelState.IsValid) 
        {
            // Legger til den gyldige modellen
            positions.Add(model);
            // Retunerer en visning kalt MapFeedback som viser listen over alle posisjoner
            return View("MapFeedback", positions);
        }
        // Dersom modellen ikker er gyldig returneres det evt feilmeldinginger
        return View(model);
    }
    
    


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
