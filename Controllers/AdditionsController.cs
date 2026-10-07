using FoodApi.Data;
using FoodApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AdditionsController : ControllerBase
{
    private readonly FoodApiDbContext _context;
    public AdditionsController(FoodApiDbContext context)
    {
        _context = context;
    }   

    [HttpGet]
    public async Task<List<Addition>> Get()
    {
        return await _context.Additions.ToListAsync();
    }
}