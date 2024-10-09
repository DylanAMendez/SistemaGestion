using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionData.Models;

namespace SistemasGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly ProductoVendidoBussiness _productoVendidoBussiness;

        public ProductoVendidoController(ILogger<ProductosController> logger, ProductoVendidoBussiness productoVendidoBussiness)
        {
            this._logger = logger;
            this._productoVendidoBussiness = productoVendidoBussiness;
        }

        [HttpGet]
        public ActionResult<List<ProductoVendidoData>> GetProductosVendidos()
        {
            return _productoVendidoBussiness.ObtenerProductosVendidos();
        }

        [HttpGet("{id}")]
        public ActionResult<ProductoVendidoData> GetUnProductosVendido(int id)
        {
            var productoVendido = _productoVendidoBussiness.ObtenerUnProductoVendido(id);

            if(productoVendido is null)
            {
                return NotFound();
            }

            return productoVendido;
        }

        [HttpPost]
        public ActionResult<ProductoVendidoData> CrearProductoVendido([FromBody] ProductoVendidoData productoVendido)
        {
            var productoVendidoCreada = _productoVendidoBussiness.CrearProductoVendido(productoVendido);
            return CreatedAtAction(nameof(CrearProductoVendido), new { id = productoVendidoCreada.Id }, productoVendido);
        }

        [HttpPut("{id}")]
        public ActionResult ModificarVenta([FromRoute(Name = "id")] int id, [FromBody] ProductoVendidoData productoVendido)
        {
            _productoVendidoBussiness.ModificarProductoVendido(id, productoVendido);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteVenta([FromRoute(Name = "id")] int id)
        {
            _productoVendidoBussiness.EliminarProductoVendido(id);
            return NoContent();
        }



    }
}
