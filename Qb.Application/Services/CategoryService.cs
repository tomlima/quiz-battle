using Qb.Domain.Entities;
using Qb.Infrastructure.Interfaces;
using Qb.Application.Interfaces;

namespace Qb.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{
    public async Task<List<Category>> GetCategories()
    {
        var categories = await categoryRepository.GetCategories();
        return categories;
    }

    public async Task<Category> GetCategoryBySlug(string categorySlug)
    {
        var category = await categoryRepository.GetCategoryBySlug(categorySlug);
        return category;
    }
}