using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CatFactsController : ControllerBase
{
    private readonly ICatFactService _catFactService;

    public CatFactsController(ICatFactService catFactService)
    {
        _catFactService = catFactService;
    }

    [HttpGet("random")]
    public async Task<IActionResult> GetRandomFact()
    {
        var fact = await _catFactService.GetRandomFactAsync();
        return Ok(new { fact });
    }
}
