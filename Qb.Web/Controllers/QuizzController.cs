using Microsoft.AspNetCore.Mvc;
using Qb.Application.Interfaces;
using Qb.Domain.Entities;
using Qb.Web.Models;
using Qb.Infrastructure.CrossCutting.Services;

namespace Qb.Web.Controllers;

public class QuizzController( ILogger<QuizzController> logger, IQuizService quizService): Controller
{
    [Route("/quizz/{id}")]
    public async Task<IActionResult> Index(int id, int index=0, bool started = false)
    {
        
        Quiz? quiz = await quizService.GetQuizById(id);
        
        if (quiz == null)
        {
            return NotFound();
        }
        
        // Check if is the last question
        if (index < 0 || index >= quiz.Questions.Count)
        {
            return RedirectToAction("Index", new { id = id });
        }
        
        var currentQuestion  = quiz.Questions[index];
        
        QuizViewModel model = new QuizViewModel
        {
            Quiz = quiz,
            Question = currentQuestion,
            QuestionIndex = index,
            QuizStarted = started,
            IsLoggedIn = UserSession.IsLoggedIn(HttpContext)
        };
        
        
        return View("~/Views/Quiz/Index.cshtml", model);
    }
}