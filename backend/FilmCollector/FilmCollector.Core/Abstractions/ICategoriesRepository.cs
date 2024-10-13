using FilmCollector.Core.Models;

namespace FilmCollector.Core.Abstractions;

public interface ICategoriesRepository
{
    Task<Guid> Create(Category category);
    Task<Guid> Delete(Guid id);
    Task<List<Category>> Get();
    Task<Guid> Update(Guid id, string title);
}