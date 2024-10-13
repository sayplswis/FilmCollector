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
                .Select(f => Film.Create(f.Id, f.Title, f.Uri, f.CategoryId, f.Description, f.ImageData).Film)
                .ToList();

            return films;
        }
        public async Task<Guid> Create(Film film)
        {
            var filmEntity = new FilmEntity()
            {
                Id = film.Id,
                Title = film.Title,
                Description = film.Description,
                CategoryId = film.CategoryId,
                ImageData = film.ImageData,
                Uri = film.Uri
            };

            await dbContext.Films.AddAsync(filmEntity);
            await dbContext.SaveChangesAsync();

            return filmEntity.Id;
        }
        public async Task<Guid> Update(Guid id, string title, string description, byte[] imageData, Guid categoryId, string uri)
        {
            await dbContext.Films
                .Where(f => f.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(p => p.Title, p => title)
                    .SetProperty(p => p.Description, p => description)
                    .SetProperty(p => p.ImageData, p => imageData)
                    .SetProperty(p => p.CategoryId, p => categoryId)
                    .SetProperty(p => p.Uri, p => uri));
            return id;
        }

        public async Task<Guid> Update(Guid id, Status status)
        {
            await dbContext.Films
                .Where(f => f.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(p => p.Status, p => status));
            return id;
        }

        public async Task<Guid> Update(Guid id, int rating)
        {
            await dbContext.Films
                .Where(f => f.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(p => p.Rating, p => rating));
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
