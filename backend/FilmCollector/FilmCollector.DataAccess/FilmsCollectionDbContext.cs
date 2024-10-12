using FilmCollector.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmCollector.DataAccess
{
    public class FilmsCollectionDbContext : DbContext
    {
        public DbSet<FilmEntity> Films { get; set; }
        public FilmsCollectionDbContext(DbContextOptions<FilmsCollectionDbContext> options) :base(options)
        {
            
        }
    }
}
