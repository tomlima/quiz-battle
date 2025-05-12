using Qb.Infrastructure.CrossCutting.Services;
using Qb.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Qb.Domain.Entities;
using Qb.Web.Models;

namespace Qb.Web.Controllers;

public class CategoryController(
    ILogger<CategoryController> logger, 
    ICategoryService categoryService,
    IQuizService quizService
) : Controller
{
    
    // Dynamic route for category with slug
    [Route("{slug}")]
    public async Task<IActionResult> Index(string slug)
    {
        ViewBag.Slug = slug;
        Category category = await categoryService.GetCategoryBySlug(slug);
        List<Quiz> quizzes = await quizService.GetQuizzesByCategory(category.Id);
        
        
        CategoryViewModel model = new CategoryViewModel
        {
            Category = category,
            Quizzes = quizzes,
            IsLoggedIn = UserSession.IsLoggedIn(HttpContext)
            
        };
        return View("~/Views/Category/Index.cshtml", model);
    }
}