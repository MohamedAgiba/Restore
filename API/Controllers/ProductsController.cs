using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

    [Route("api/[controller]")]
[ApiController] // https://localhost:5001/api/products
public class ProductsController(StoreContext context) : ControllerBase
{   
    private readonly StoreContext context = context;

    [HttpGet]
        //using async methods is the best practice for database calls, as it allows the server to handle other requests while waiting for the database response.   
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return await context.Products.ToListAsync();  
    }
    [HttpGet("{id}")] //api/products/1
    public async Task <ActionResult<Product>> GetProduct(int id)
    {
        var product = await context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return product;
    }
}
