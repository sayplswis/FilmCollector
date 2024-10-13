using FilmCollector.Core.Models;

namespace FilmCollector.Core.Abstractions
{
    public interface IFilmsRepository
    {
        Task<Guid> Create(Film film);
        Task<Guid> Delete(Guid id);
        Task<List<Film>> Get();
        Task<Guid> Update(Guid id, string title, string description, byte[] imageData, Guid categoryId, string uri);
        Task<Guid> Update(Guid id, Status status);
        Task<Guid> Update(Guid id, int rating);
    }
}