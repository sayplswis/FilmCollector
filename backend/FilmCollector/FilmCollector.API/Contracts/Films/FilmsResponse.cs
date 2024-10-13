using FilmCollector.Core.Models;

namespace FilmCollector.API.Contracts
{
    public record FilmsResponse(Guid id, string title, string description, byte[] image, string uri, Guid categoryId, Status status, int rating);
}
