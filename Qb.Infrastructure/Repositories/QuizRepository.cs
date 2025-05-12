using Microsoft.EntityFrameworkCore;
using Qb.Domain.Entities;
using Qb.Infrastructure.Interfaces;

namespace Qb.Infrastructure.Repositories;


public class QuizRepository(ApplicationDbContext context): IQuizRepository
{

    public async Task<List<Quiz>> GetFaturedQuizzes()
    {
        return  await context.Quizzes
            .Where(q => q.Featured == true)
            .ToListAsync();
    }
    public async Task<List<Quiz>> GetQuizzesByCategory(int categoryId)
    {
        List<Quiz> quizzes = await context.Quizzes
            .Where(q => q.Category.Id == categoryId)
            .ToListAsync();
        return quizzes;
    }

    public async Task<Quiz?> GetQuizById(int id)
    {
        Quiz? quiz = await context.Quizzes
            .Include(q => q.Questions)         
            .ThenInclude(question => question.Answers) 
            .FirstOrDefaultAsync(q => q.Id == id);
        return quiz;
    }
}