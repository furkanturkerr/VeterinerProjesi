using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutBlogComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}