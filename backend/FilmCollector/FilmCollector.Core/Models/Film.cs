namespace FilmCollector.Core.Models
{
    public class Film
    {
        public Guid Id { get; }
        public string Title { get; }
        public string Description { get;}
        public byte[] ImageData { get; }
        public Guid CategoryId { get; }
        public string Uri { get; }
        public Status Status { get; }
        public int Rating { get; }

        private Film(Guid id, string title, string uri, Guid categoryId, string description, byte[] imageData, Status status , int rating)
        {
            Id = id;
            Title = title; 
            Description = description;
            CategoryId = categoryId;
            Uri = uri;
            ImageData = imageData;
            Status = status;
            Rating = rating;
        }

        public static (Film Film, string Error) Create(Guid id, string title, string uri, Guid categoryId, string description, byte[] imageData)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(title))
            {
                error = "Пустой заголовок";
            }
            if (string.IsNullOrEmpty(uri))
            {
                error = "Пустая ссылка";
            }
            var film = new Film(id, title, uri, categoryId, description, imageData, Status.Waiting, 0);
            return (film, error);
        }
    }
}
