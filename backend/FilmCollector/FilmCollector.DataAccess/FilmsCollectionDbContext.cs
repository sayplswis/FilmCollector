using FilmCollector.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmCollector.DataAccess
{
    public class FilmsCollectionDbContext(DbContextOptions<FilmsCollectionDbContext> options) : DbContext(options)
    {
        public DbSet<FilmEntity> Films { get; set; } = null!;
        public DbSet<CategoryEntity> Categories { get; set; }= null!;
    }
}
