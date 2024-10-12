using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;
using FilmCollector.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmCollector.DataAccess.Repositories
{
    public class FilmsRepository(FilmsCollectionDbContext dbContext) : IFilmsRepository
    {
        public async Task<List<Film>> Get()
        {
            var filmEntities = await dbContext.Films
                .AsNoTracking()
                .ToListAsync();

            var films = filmEntities
                .Select(f => Film.Create(f.Id, f.Title, f.Description).Film)
                .ToList();

            return films;
        }
        public async Task<Guid> Create(Film film)
        {
            var filmEntity = new FilmEntity()
            {
                Id = film.Id,
                Title = film.Title,
                Description = film.Description
            };

            await dbContext.Films.AddAsync(filmEntity);
            await dbContext.SaveChangesAsync();

            return filmEntity.Id;
        }
        public async Task<Guid> Update(Guid id, string title, string description)
        {
            await dbContext.Films
                .Where(f => f.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Title, p => title)
                .SetProperty(p => p.Title, p => description));
            return id;
        }
        public async Task<Guid> Delete(Guid id)
        {
            await dbContext.Films.Where(f => f.Id == id).ExecuteDeleteAsync();
            await dbContext.SaveChangesAsync();
            return id;
        }
    }
}
