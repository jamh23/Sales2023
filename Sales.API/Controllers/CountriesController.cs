using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.Shared.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("/api/countries")]
    public class CountriesController : ControllerBase
    {
        private readonly Datacontext _context;

        public CountriesController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> GetAsync() 
        {
            return Ok(await _context.Countries.ToListAsync());
        
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetAsync(int id)
        {


            return Ok();

        }

        [HttpPost]

        public async Task<ActionResult> Post(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);

        
        }

    }
}
