using Qb.Domain.Entities;
using Qb.Infrastructure.Interfaces;

namespace Qb.Infrastructure.Repositories;

public class CategoryRepository(ApplicationDbContext context):ICategoryRepository
{
    
    public async Task<List<Category>> GetCategories()
    {
        List<Category> categories = context.Categories.ToList();
        return categories;
    }

    public async Task<Category> GetCategoryBySlug(string categorySlug)
    {
        Category category = context.Categories.SingleOrDefault(c => c.Slug == categorySlug);
        return category;
    }
}