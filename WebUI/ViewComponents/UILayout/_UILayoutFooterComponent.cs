using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutFooterComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}