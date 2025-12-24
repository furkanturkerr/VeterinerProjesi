using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}