using Microsoft.EntityFrameworkCore;
using Qb.Domain.Entities;
using Qb.Infrastructure.Interfaces;

namespace Qb.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext context):IUserRepository
{
    public async Task<User?> GetUserByEmail(string email)
    {
        User? user =  await context.Users.SingleOrDefaultAsync(user => user.Email == email);
        return user;
    }
}