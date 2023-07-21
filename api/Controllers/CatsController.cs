using vue_cat_browser_api.Models;
using vue_cat_browser_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace vue_cat_browser_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatsController : ControllerBase
{
  private readonly CatsService _catsService;

  public CatsController(CatsService catsService) =>
      _catsService = catsService;

  [HttpGet]
  public async Task<List<Cat>> Get() =>
      await _catsService.GetAsync();

  [HttpGet("{id:length(24)}")]
  public async Task<ActionResult<Cat>> Get(string id)
  {
    var cat = await _catsService.GetAsync(id);

    if (cat is null)
    {
      return NotFound();
    }

    return cat;
  }

  [HttpPost]
  public async Task<IActionResult> Post(Cat newCat)
  {
    await _catsService.CreateAsync(newCat);

    return CreatedAtAction(nameof(Get), new { id = newCat.Id }, newCat);
  }

  [HttpPut("{id:length(24)}")]
  public async Task<IActionResult> Update(string id, Cat updatedCat)
  {
    var cat = await _catsService.GetAsync(id);

    if (cat is null)
    {
      return NotFound();
    }

    updatedCat.Id = cat.Id;

    await _catsService.UpdateAsync(id, updatedCat);

    return NoContent();
  }

  [HttpDelete("{id:length(24)}")]
  public async Task<IActionResult> Delete(string id)
  {
    var cat = await _catsService.GetAsync(id);

    if (cat is null)
    {
      return NotFound();
    }

    await _catsService.RemoveAsync(id);

    return NoContent();
  }
}