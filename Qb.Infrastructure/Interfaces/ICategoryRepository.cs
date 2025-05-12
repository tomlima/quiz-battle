using Qb.Domain.Entities;

namespace Qb.Infrastructure.Interfaces;

public interface ICategoryRepository
{
    public Task<List<Category>> GetCategories();
    public Task<Category> GetCategoryBySlug(string categorySlug);
}