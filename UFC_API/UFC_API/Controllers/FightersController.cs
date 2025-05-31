using Microsoft.AspNetCore.Mvc;
using UFC_API.Data;
using UFC_API.Models;
using Microsoft.EntityFrameworkCore;

namespace UFC_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FightersController : ControllerBase
{
    private readonly AppDbContext _context;

    public FightersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Fighter>>> GetFighters()
    {
        return await _context.Fighters.ToListAsync();
    }
}