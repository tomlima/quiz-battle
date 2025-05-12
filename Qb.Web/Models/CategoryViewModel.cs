using Qb.Domain.Entities;
namespace Qb.Web.Models;

public class CategoryViewModel
{
    public Category Category { get; set; }
    
    public List<Quiz> Quizzes { get; set; }
    
    public required bool  IsLoggedIn { get; set; }
}