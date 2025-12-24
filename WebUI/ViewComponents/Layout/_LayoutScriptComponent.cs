using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.Layout;

public class _LayoutScriptComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}