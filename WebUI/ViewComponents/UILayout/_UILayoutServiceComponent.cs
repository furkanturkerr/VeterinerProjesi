using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutServiceComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}