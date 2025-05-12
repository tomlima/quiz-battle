using Microsoft.AspNetCore.Mvc;
using Qb.Application.Interfaces;
using Qb.Domain.DTO;
using Qb.Infrastructure.CrossCutting.Services;
using Qb.Web.Models; // Assuming you have a category service

namespace Tectools.Web.Components
{
    public class HeaderViewComponent(ICategoryService _categoryService) : ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryService.GetCategories();
            UserSessionDto userSession = null;

            if (UserSession.IsLoggedIn(HttpContext))
            {
                userSession = UserSession.GetSession(HttpContext);
            }
            
            
            TemplateViewModel model = new TemplateViewModel
            {
                Categories = categories,
                UserSession = userSession,
                IsLoggedIn = UserSession.IsLoggedIn(HttpContext)
            };
            
            // Return the view with categories
            return View(model);
        }
    }
}