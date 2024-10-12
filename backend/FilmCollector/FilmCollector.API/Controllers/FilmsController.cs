using FilmCollector.API.Contracts;
using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmCollector.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmsController(IFilmsService filmsService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<FilmsResponse>>> GetFilms()
        {
            var films = await filmsService.GetAllFilms();
            var response = films.Select(f=> new FilmsResponse(f.Id,f.Title,f.Description));
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateFilm([FromBody] FilmsRequest request)
        {
            var result = Film.Create(Guid.NewGuid(), request.title, request.description);

            if(!string.IsNullOrEmpty(result.Error))
                return BadRequest(result.Error);

            await filmsService.CreateFilm(result.Film);
            return Ok(result.Film.Id);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateFilm(Guid id, [FromBody] FilmsRequest request)
        {
            var filmId = await filmsService.UpdateFilm(id, request.title, request.description);
            return Ok(filmId);

        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteFilm(Guid id)
        {
            return Ok(await filmsService.DeleteFilm(id));   
        }
    }
}
