using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutHeadComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}