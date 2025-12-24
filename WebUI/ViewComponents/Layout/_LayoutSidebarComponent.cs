using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.Layout;

public class _LayoutSidebarComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}