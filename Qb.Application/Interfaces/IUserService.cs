using Qb.Domain.Entities;
namespace Qb.Application.Interfaces;

public interface IUserService
{
    public Task<User?> GetUserByEmail(string email);
}