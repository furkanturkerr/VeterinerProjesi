using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}