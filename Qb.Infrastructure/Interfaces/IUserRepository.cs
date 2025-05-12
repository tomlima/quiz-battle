using Qb.Domain.Entities;
namespace Qb.Infrastructure.Interfaces;

public interface IUserRepository
{
    public Task<User?> GetUserByEmail(string email);
}