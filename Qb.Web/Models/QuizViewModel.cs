using Qb.Domain.Entities;
namespace Qb.Web.Models;

public class QuizViewModel
{
    public Quiz Quiz { get; set; }
    public Question Question { get; set; }
    public int QuestionIndex { get; set; }  
    
    public bool QuizStarted { get; set; }
    
    public required bool IsLoggedIn { get; set; }

}