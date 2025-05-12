using Qb.Domain.Entities;

namespace Qb.Infrastructure.Interfaces;

public interface IQuizRepository
{
    public Task<List<Quiz>> GetFaturedQuizzes();
    public Task<List<Quiz>> GetQuizzesByCategory(int categoryId);
    public Task<Quiz?> GetQuizById(int quizzId);
}