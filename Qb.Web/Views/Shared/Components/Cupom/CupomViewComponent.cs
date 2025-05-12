using Microsoft.AspNetCore.Mvc;

namespace Qb.Web.Views.Shared.Components.Cupom;

public class CupomViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        // logic here
        return View();
    }
}