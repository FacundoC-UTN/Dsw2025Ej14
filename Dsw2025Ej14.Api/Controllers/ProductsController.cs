
using Dsw2025Ej14.Api.Data;
using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IPersistencia _repo;
    public ProductsController(IPersistencia repo) => _repo = repo;

    // 1) GET /api/products  <— solo uno de estos
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        var activos = _repo.GetProducts().ToList();
        if (!activos.Any())
            return NoContent();
        return Ok(activos);
    }

    // 2) GET /api/products/{sku}
    [HttpGet("{sku}")]
    public ActionResult<Product> GetBySku(string sku)
    {
        var p = _repo.GetProduct(sku);
        if (p is null)
            return NotFound();
        return Ok(p);
    }
}