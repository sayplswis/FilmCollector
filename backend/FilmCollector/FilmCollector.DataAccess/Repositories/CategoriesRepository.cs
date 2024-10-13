using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;
using FilmCollector.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmCollector.DataAccess.Repositories;

public class CategoriesRepository(FilmsCollectionDbContext dbContext) : ICategoriesRepository
{
    public async Task<Guid> Create(Category category)
    {
        var categoryEntity = new CategoryEntity()
        {
            Id = category.Id,
            Title = category.Title,
        };

        await dbContext.Categories.AddAsync(categoryEntity);
        await dbContext.SaveChangesAsync();

        return categoryEntity.Id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await dbContext.Categories.Where(f => f.Id == id).ExecuteDeleteAsync();
        await dbContext.SaveChangesAsync();
        return id;
    }

    public async Task<List<Category>> Get()
    {
        var categoryEntities = await dbContext.Categories
            .AsNoTracking()
            .ToListAsync();

        var categories = categoryEntities
            .Select(f => Category.Create(f.Id, f.Title).Category)
            .ToList();

        return categories;
    }

    public async Task<Guid> Update(Guid id, string title)
    {
        await dbContext.Categories
            .Where(c => c.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Title, p => title));
        return id;
    }
}