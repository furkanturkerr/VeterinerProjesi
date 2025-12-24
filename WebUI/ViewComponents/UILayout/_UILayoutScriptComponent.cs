using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutScriptComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}