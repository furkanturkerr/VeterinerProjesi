using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutTeamComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}