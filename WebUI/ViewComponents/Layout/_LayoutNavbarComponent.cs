using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.Layout;

public class _LayoutNavbarComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}