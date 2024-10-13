namespace FilmCollector.DataAccess.Entities;

public class CategoryEntity
{
    public Guid Id { get; init; }
    public string Title { get; set; } = string.Empty;
    public List<FilmEntity> Films { get; set; } = [];
}