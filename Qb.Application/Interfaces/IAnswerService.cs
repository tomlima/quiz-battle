using Qb.Domain.Entities;

namespace Qb.Application.Interfaces;

public interface IAnswerService
{
    public Task<List<Answer>> GetAnswersByQuestion(int questionId);
}