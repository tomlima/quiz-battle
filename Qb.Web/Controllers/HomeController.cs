using System.Diagnostics;
using Qb.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Qb.Web.Models;
using Qb.Domain.Entities;
namespace Qb.Web.Controllers;

public class HomeController(
    ILogger<HomeController> logger, 
    ICategoryService categoryService,
    IQuizService quizService
    ) : Controller
{
    
    public async Task<IActionResult> Index()
    {
        var categories = await categoryService.GetCategories();
        List<Quiz> quizzes = await quizService.GetFaturedQuizzes();
        
        HomeViewModel model = new HomeViewModel
        {
            Quizzes = quizzes
        };  
        return View(model);
    }
}