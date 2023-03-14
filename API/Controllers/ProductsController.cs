using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;

        }

        // Kako generalno radi, httpget je poziv za get metodu
        // Ovaj ActionResult je ce na pozvati listu proizvoda i nad njima uraditi Get
        // Kreira se promenljiva za store var products, proizvodi u listu i vraca 200(Ok)
        // Zajedno sa proizvodima
        // [HttpGet]
        // public ActionResult<List<Product>> GetProducts()
        // {
        //     var products = context.Products.ToList();

        //     return Ok(products);
        // }
        // Ovde vraca uz odgovarajuci proizvod ali mora da se prosledi id
        // Ovaj i nacin iznad rade sinhrono, drugde mi je primer za asinhrono vracanje samo dela
        // necega iz Get metode
        // [HttpGet("{id}")]
        // public ActionResult<Product>GetProduct(int id)
        // {
        //     return context.Products.Find(id);
        // }

        //Primer asinhrone naredbe
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}