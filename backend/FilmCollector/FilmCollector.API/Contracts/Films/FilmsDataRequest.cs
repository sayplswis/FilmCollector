namespace FilmCollector.API.Contracts
{
    public record FilmsDataRequest(string title, string uri, string description, byte[] image, Guid categoryId);
}
