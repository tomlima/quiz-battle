using Qb.Domain.Entities;

namespace Qb.Infrastructure.Interfaces;

public interface IAnswerRepository
{
    public Task<List<Answer>> GetAnswersByQuestion(int questionId);
}