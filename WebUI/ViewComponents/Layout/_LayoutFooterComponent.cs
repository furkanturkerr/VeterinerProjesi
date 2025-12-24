using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.Layout;

public class _LayoutFooterComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}