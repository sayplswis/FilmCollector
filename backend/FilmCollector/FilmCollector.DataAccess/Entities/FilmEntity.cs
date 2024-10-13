using FilmCollector.Core.Models;

namespace FilmCollector.DataAccess.Entities
{
    public class FilmEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public byte[] ImageData { get; set; } = [];
        public Guid CategoryId { get; set; }
        public CategoryEntity? Category { get; set; }
        public string Uri { get; set;} = string.Empty;
        public Status Status { get; set; } = Status.Waiting;
        public int Rating { get; set; } = 0;
    }
}
