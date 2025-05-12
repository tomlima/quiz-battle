using Qb.Domain.Entities;

namespace Qb.Infrastructure.Interfaces;

public interface IQuestionRepository
{
    public List<Question> GetQuestionsByQuiz(int quizId);
}