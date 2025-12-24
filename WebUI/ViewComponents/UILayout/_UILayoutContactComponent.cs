using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutContactComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}