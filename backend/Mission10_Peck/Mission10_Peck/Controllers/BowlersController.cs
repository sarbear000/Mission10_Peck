using Mission10_Peck.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Peck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class BowlersController : Controller
    {
        private BowlersDbContext _bowlerContext;
        
        public BowlersController(BowlersDbContext temp)
        {
            _bowlerContext = temp;
        }

        [HttpGet]
        public IActionResult GetBowlers()
        {
            var bowlers = _bowlerContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .ToList();
            return Ok(bowlers);
        }
    }
}