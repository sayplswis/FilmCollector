using FilmCollector.Core.Models;

namespace FilmCollector.Core.Abstractions
{
    public interface IFilmsService
    {
        Task<Guid> CreateFilm(Film film);
        Task<Guid> DeleteFilm(Guid id);
        Task<List<Film>> GetAllFilms();
        Task<Guid> UpdateFilm(Guid id, string title, string description);
    }
}