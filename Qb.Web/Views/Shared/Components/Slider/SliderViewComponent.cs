using Microsoft.AspNetCore.Mvc;
using Qb.Domain.Entities;

namespace Tectools.Web.Views.Shared.Components.Slider;

public class SliderViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(List<Quiz> list)
    {
        return View(list);
    }
}