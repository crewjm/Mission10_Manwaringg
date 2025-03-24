using BowlingLeague.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("[controller]")]
[ApiController]

//public bowler controller class
public class BowlerController : ControllerBase
{
    private readonly BowlerDbContext _context;

    public BowlerController(BowlerDbContext context)
    {
        _context = context;
    }

    // GET clause using http and all of the database info
    [HttpGet(Name = "GetBowler")]
    public async Task<IActionResult> Get()
    {
        var bowlers = await _context.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
            .Select(b => new
            {
                b.BowlerId,
                b.BowlerFirstName,
                b.BowlerMiddleInit,
                b.BowlerLastName,
                b.BowlerAddress,
                b.BowlerCity,
                b.BowlerState, 
                b.BowlerZip,
                b.BowlerPhoneNumber,
                TeamName = b.Team != null ? b.Team.TeamName : "No Team"
            })
            .ToListAsync();

        return Ok(bowlers);
    }

}