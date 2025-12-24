using Microsoft.AspNetCore.Mvc;

namespace VeterinerProjesi.ViewComponents.UILayout;

public class _UILayoutAppointmentComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}