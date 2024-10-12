using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;

namespace FilmCollector.Application.Services
{
    public class FilmsService(IFilmsRepository repository) : IFilmsService
    {
        public async Task<List<Film>> GetAllFilms() => await repository.Get();
        public async Task<Guid> CreateFilm(Film film) => await repository.Create(film);
        public async Task<Guid> UpdateFilm(Guid id, string title, string description) => await repository.Update(id, title, description);
        public async Task<Guid> DeleteFilm(Guid id) => await repository.Delete(id);
    }
}
