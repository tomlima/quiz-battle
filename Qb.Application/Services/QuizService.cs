using Qb.Application.Interfaces;
using Qb.Domain.Entities;
using Qb.Infrastructure.Interfaces;

namespace Qb.Application.Services;

public class QuizService(IQuizRepository repository): IQuizService
{
        public async Task<List<Quiz>> GetFaturedQuizzes()
        {
                var quizzes = await repository.GetFaturedQuizzes();
                return quizzes;
        }
        public async Task<List<Quiz>> GetQuizzesByCategory(int categoryId)
        {
                var quizzes = await repository.GetQuizzesByCategory(categoryId);
                return quizzes;
        }

        public async Task<Quiz?> GetQuizById(int id)
        {
                var quiz = await repository.GetQuizById(id);
                return quiz;
        }
        
        
}