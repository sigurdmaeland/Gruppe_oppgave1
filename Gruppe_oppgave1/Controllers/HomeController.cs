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
    public IActionResult MapModel()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MapModel(MapModel model)
    {
        if (ModelState.IsValid)
        {
            positions.Add(model);
            return View("MapFeedback", positions);
        }
        return View(model);
    }
    
    


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
