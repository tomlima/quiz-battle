using Microsoft.AspNetCore.Http;
using Qb.Domain.Entities;
using Qb.Infrastructure.Interfaces;

namespace Qb.Infrastructure.Repositories;

public class QuestionRepository(ApplicationDbContext context): IQuestionRepository
{
    public List<Question> GetQuestionsByQuiz(int quizId)
    {
        List<Question> questions = new List<Question>();
        return questions;
    }
}