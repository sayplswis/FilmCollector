using FilmCollector.Core.Models;

namespace FilmCollector.Core.Abstractions;

public interface ICategoriesService
{
    Task<Guid> CreateCategory(Category category);
    Task<Guid> DeleteCategory(Guid id);
    Task<List<Category>> GetCategories();
    Task<Guid> UpdateCategory(Guid id, string title);
}