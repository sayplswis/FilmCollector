using FilmCollector.API.Contracts.Category;
using FilmCollector.Core.Abstractions;
using FilmCollector.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmCollector.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController(ICategoriesService categoriesService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<CategoriesResponse>>> GetFilms()
    {
        var categories = await categoriesService.GetCategories();
        var response = categories.Select(f =>
            new CategoriesResponse(f.Id, f.Title));
        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<Guid>> CreateFilm([FromBody] CategoriesDataRequest request)
    {
        var result = Category.Create(Guid.NewGuid(), request.title);
    
        if(!string.IsNullOrEmpty(result.Error))
            return BadRequest(result.Error);
    
        await categoriesService.CreateCategory(result.Category);
        return Ok(result.Category.Id);
    }
    
    [HttpPut("{id:guid}")]
    public async Task<ActionResult<Guid>> UpdateCategoryData(Guid id, [FromBody] CategoriesDataRequest request)
    {
        var categoryId = await categoriesService.UpdateCategory(id, request.title);
        return Ok(categoryId);
    }
    [HttpDelete("{id:guid}")]
    public async Task<ActionResult<Guid>> DeleteCategory(Guid id)
    {
        return Ok(await categoriesService.DeleteCategory(id));   
    }
}