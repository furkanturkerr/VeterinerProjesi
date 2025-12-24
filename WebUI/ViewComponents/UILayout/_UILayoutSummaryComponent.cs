using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutSummaryComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}