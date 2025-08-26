using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiOracleCats.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatsController : ControllerBase
    {
        private readonly CatContext _context;

        public CatsController(CatContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCats()
        {
            var cats = await _context.Cats.Include(c => c.Breed).ToListAsync();
            return Ok(cats);
        }
    }
}
