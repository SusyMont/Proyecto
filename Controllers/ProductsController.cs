using FoodApi.Models;
using Microsoft.AspNetCore.Mvc;
using FoodApi.Data;
using Microsoft.EntityFrameworkCore;

namespace FoodApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase {

    private readonly FoodApiDbContext _context;
    public ProductsController(FoodApiDbContext context) {
        _context = context;
    }
    [HttpGet]
    public IEnumerable<Product> Get() {
        return _context.Products.Include(product => product.Opciones).ToList();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await _context.Products
            .Include(product => product.Opciones)
            .FirstOrDefaultAsync(product => product.Id == id);

        if (product is null)
        {
            return NotFound();
        }

        return product;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> Create(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return StatusCode(StatusCodes.Status201Created, product);
    }

    [HttpPut("{id:int}")]
public async Task<ActionResult<Product>> Update(int id, Product updatedProduct)
{
    var product = await _context.Products
    .Include(product => product.Opciones)
    .FirstOrDefaultAsync(product => product.Id == id);

    if (product is null)
    {
        return NotFound();
    }

    product.Nombre = updatedProduct.Nombre;
    product.Precio = updatedProduct.Precio;
    product.Descripcion = updatedProduct.Descripcion;
    product.Disponible = updatedProduct.Disponible;

    await _context.SaveChangesAsync();

    return Ok(product);
}

[HttpDelete("{id:int}")]
public async Task<IActionResult> Delete(int id) {
    var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
    if (product is null)
        {
            return NotFound();
        }

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return NoContent();
}
}