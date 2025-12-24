using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.Layout;

public class _LayoutHeaderComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }  
}