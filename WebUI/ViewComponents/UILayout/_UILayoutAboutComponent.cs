using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutAboutComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}