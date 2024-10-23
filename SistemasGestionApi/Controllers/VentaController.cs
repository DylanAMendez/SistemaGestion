using ClaseDesafio.Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionData.Models;

namespace SistemasGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly VentaBussiness _ventaBussiness;

        public VentaController(ILogger<ProductosController> logger, VentaBussiness ventaBussiness)
        {
            this._logger = logger;
            this._ventaBussiness = ventaBussiness;
        }

        [HttpGet(Name = "Get Ventas")]
        public ActionResult<List<VentaData>> GetVentas()
        {
            return _ventaBussiness.ObtenerVentas();
        }

        [HttpGet("{id}")]
        public ActionResult<VentaData> GetUnaVenta(int id)
        {
            var venta = _ventaBussiness.ObtenerUnaVenta(id);

            if (venta is null)
            {
                return NotFound();
            }

            return venta;
        }

        [HttpPost]
        public ActionResult<VentaData> CrearVenta([FromBody] VentaData venta)
        {
            var ventaCreada = _ventaBussiness.CrearVenta(venta);
            var productosVendidos = venta.ProductosVendidos;

            ProductoVendidoBussiness _productoVendidoBussiness = new ProductoVendidoBussiness();
            ProductoBussiness _productoBussiness = new ProductoBussiness();

            foreach (var productoVendido in productosVendidos)
            {
                //productoVendido.IdVenta = ventaCreada.Id;

                _productoVendidoBussiness.CrearProductoVendido(productoVendido);

                var producto = _productoBussiness.ObtenerUnProducto(productoVendido.IdProducto);
                producto.Stock -= productoVendido.stock;

                _productoBussiness.ModificarUnProducto(producto.Id, producto);
            }

            return CreatedAtAction(nameof(CrearVenta), new { id = ventaCreada.Id }, ventaCreada);
        }




        [HttpPut("{id}")]
        public ActionResult ModificarVenta([FromRoute(Name = "id")] int id, [FromBody] VentaData venta)
        {
            _ventaBussiness.ModificarVenta(id, venta);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteVenta([FromRoute(Name = "id")] int id)
        {
            _ventaBussiness.EliminarVenta(id);
            return NoContent();
        }


    }
}
