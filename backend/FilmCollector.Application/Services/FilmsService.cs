using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;

namespace FilmCollector.Application.Services
{
    public class FilmsService(IFilmsRepository repository) : IFilmsService
    {
        public async Task<List<Film>> GetAllFilms() => await repository.Get();
        public async Task<Guid> CreateFilm(Film film) => await repository.Create(film);
        public async Task<Guid> UpdateFilmData(Guid id, string title, string description, byte[] imageData, Guid categoryId, string uri) => await repository.Update(id, title, description, imageData, categoryId, uri);
        public async Task<Guid> UpdateFilmStatus(Guid id, Status status) => await repository.Update(id, status);
        public async Task<Guid> UpdateFilmRating(Guid id, int rating) => await repository.Update(id, rating);
        public async Task<Guid> DeleteFilm(Guid id) => await repository.Delete(id);
    }
}
