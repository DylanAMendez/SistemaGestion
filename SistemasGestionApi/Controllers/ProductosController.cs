using ClaseDesafio.Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;
using SistemaGestionData.Models;


namespace SistemasGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly ProductoBussiness _productoBussiness;

        public ProductosController(ILogger<ProductosController> logger, ProductoBussiness productoBussiness) 
        {
            this._logger = logger;
            this._productoBussiness = productoBussiness;
        }

        [HttpGet(Name = "Get Productos")]
        public ActionResult<List<ProductoData>> GetProductos()
        {
            return _productoBussiness.GetProductos();
        }

        [HttpGet("{id}")]
        public ActionResult<ProductoData> GetProducto(int id)
        {
            _logger.LogInformation("Consultando por el producto con id : {id}", id);

            var producto = _productoBussiness.ObtenerUnProducto(id);

            if(producto is null)
            {
                return NotFound();
            }

            return producto;

        }

        [HttpPost]
        public ActionResult<ProductoData> CrearProducto([FromBody] ProductoData producto)
        {
            var productoCreado = _productoBussiness.CrearUnProducto(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = productoCreado.Id }, producto);
        }

        [HttpPut("{id}")]
        public ActionResult ModificarProducto([FromRoute(Name = "id")] int id, [FromBody] ProductoData producto)
        {
            _productoBussiness.ModificarUnProducto(id, producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProducto([FromRoute(Name = "id")] int id)
        {
            ProductoVendidoBussiness productoVendidoBussiness = new ProductoVendidoBussiness();
            productoVendidoBussiness.EliminarProductoVendido(id);

            _productoBussiness.EliminarUnProducto(id);
            return NoContent();
        }



    }
}
