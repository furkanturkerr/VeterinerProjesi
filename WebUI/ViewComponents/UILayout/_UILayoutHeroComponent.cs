using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutHeroComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}