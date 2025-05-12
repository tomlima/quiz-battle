using Qb.Application.Interfaces;
using Qb.Infrastructure.Interfaces;
using Qb.Domain.Entities;

namespace Qb.Application.Services;

public class UserService(IUserRepository repository): IUserService
{
    public async Task<User?> GetUserByEmail(string email)
    {
        User? user = await repository.GetUserByEmail(email);
        return user;    
    }
}