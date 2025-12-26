using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.Areas.Admin.Controllers;
[Area("Admin")]
public class UISettingsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}