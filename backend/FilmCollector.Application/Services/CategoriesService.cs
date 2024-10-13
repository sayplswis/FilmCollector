using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;

namespace FilmCollector.Application.Services;

public class CategoriesService(ICategoriesRepository repository) : ICategoriesService
{
    public async Task<Guid> CreateCategory(Category category) => await repository.Create(category);

    public async Task<Guid> DeleteCategory(Guid id) => await repository.Delete(id);

    public async Task<List<Category>> GetCategories() => await repository.Get();

    public async Task<Guid> UpdateCategory(Guid id, string title) => await repository.Update(id, title);
}