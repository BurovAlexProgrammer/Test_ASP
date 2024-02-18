using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.DAL.Postgres;

namespace TestApp.API.Controllers;

[ApiController]
public class AuthorController : Controller
{
    private PostgresDbContext _dbContext;

    public AuthorController(PostgresDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // GET
    [HttpGet]
    [Route("Author")]
    public async Task<IActionResult> Index()
    {
        var authors = _dbContext.Authors.ToList();
        return Ok(Utf8Json.JsonSerializer.ToJsonString(authors));
    }
}