using FilmCollector.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilmCollector.DataAccess.Configurations
{
    public class FilmConfiguration : IEntityTypeConfiguration<FilmEntity>
    {
        public void Configure(EntityTypeBuilder<FilmEntity> builder)
        {
            builder.
                HasKey(x => x.Id);
            builder
                .HasOne(x => x.Category)
                .WithMany(c => c.Films)
                .HasForeignKey(c => c.CategoryId);
            builder
                .Property(x => x.Title)
                .IsRequired();
            builder
                .Property(x => x.Uri)
                .IsRequired();
        }
    }
}
