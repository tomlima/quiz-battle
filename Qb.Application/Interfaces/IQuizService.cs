using Qb.Domain.Entities;

namespace Qb.Application.Interfaces;

public interface IQuizService
{
    public Task<List<Quiz>> GetFaturedQuizzes();
    public Task<List<Quiz>> GetQuizzesByCategory(int categoryId);
    public Task<Quiz?> GetQuizById(int quizId);
}