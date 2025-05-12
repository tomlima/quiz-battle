using Qb.Domain.Entities;

namespace Qb.Application.Interfaces;

public interface ICategoryService
{
    public Task<List<Category>> GetCategories();
    public Task<Category> GetCategoryBySlug(string categorySlug);
}