namespace FilmCollector.Core.Models;

public class Category
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public Category(Guid id, string title)
    {
        Id = id;
        Title = title;
    }

    public static (Category Category, string Error) Create(Guid id, string title)
    {
        var error = string.Empty;
        if (string.IsNullOrEmpty(title))
        {
            error = "Пустой заголовок";
        }
        var category = new Category(id, title);
        return (category, error);
    }
}