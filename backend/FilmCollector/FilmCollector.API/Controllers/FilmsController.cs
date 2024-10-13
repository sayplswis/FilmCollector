using FilmCollector.API.Contracts;
using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmCollector.API.Controllers
{
     
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController(IFilmsService filmsService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<FilmsResponse>>> GetFilms()
        {
            var films = await filmsService.GetAllFilms();
            var response = films.Select(f =>
                new FilmsResponse(f.Id, f.Title, f.Description, f.ImageData, f.Uri, f.CategoryId, f.Status, f.Rating));
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateFilm([FromBody] FilmsDataRequest request)
        {
            var result = Film.Create(Guid.NewGuid(), request.title, request.uri, request.categoryId, request.description,
                request.image);

            if(!string.IsNullOrEmpty(result.Error))
                return BadRequest(result.Error);

            await filmsService.CreateFilm(result.Film);
            return Ok(result.Film.Id);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateFilmData(Guid id, [FromBody] FilmsDataRequest request)
        {
            var filmId = await filmsService.UpdateFilmData(id, request.title, request.description, request.image,
                request.categoryId, request.uri);
            return Ok(filmId);
        }
        [HttpPut("status/{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateFilmStatus(Guid id, [FromBody] FilmsStatusRequest request)
        {
            var filmId = await filmsService.UpdateFilmStatus(id, request.status);
            return Ok(filmId);
        }
        [HttpPut("rating/{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateFilmRating(Guid id, [FromBody] FilmsRatingRequest request)
        {
            var filmId = await filmsService.UpdateFilmRating(id, request.rating);
            return Ok(filmId);
        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteFilm(Guid id)
        {
            return Ok(await filmsService.DeleteFilm(id));   
        }
    }
}
