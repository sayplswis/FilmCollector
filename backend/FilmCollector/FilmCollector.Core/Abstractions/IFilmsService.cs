using FilmCollector.Core.Models;

namespace FilmCollector.Core.Abstractions
{
    public interface IFilmsService
    {
        Task<Guid> CreateFilm(Film film);
        Task<Guid> DeleteFilm(Guid id);
        Task<List<Film>> GetAllFilms();
        Task<Guid> UpdateFilmData(Guid id, string title, string description, byte[] imageData, Guid categoryId, string uri);
        Task<Guid> UpdateFilmStatus(Guid id, Status status);
        Task<Guid> UpdateFilmRating(Guid id, int rating);
    }
}