using SistemaGestionData.Database;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendidoData> ObtenerProductosVendidos()
        {
            return ProductoVendidoDataAccess.ObtenerProductoVendidos();
        }
        public static ProductoVendidoData ObtenerUnProductoVendido(int id)
        {
            return ProductoVendidoDataAccess.ListarProductoVendido(id);
        }
        public static ProductoVendidoData CrearProductoVendido(ProductoVendidoData productoVendidoCreado)
        {
            return ProductoVendidoDataAccess.CrearProductoVendido(productoVendidoCreado);
        }
        public static ProductoVendidoData ModificarProductoVendido(int id, ProductoVendidoData productoVendidoModificado)
        {
            return ProductoVendidoDataAccess.ModificarProductoVendido(id, productoVendidoModificado);
        }
        public static ProductoVendidoData EliminarProductoVendido(int id)
        {
            return ProductoVendidoDataAccess.EliminarProductoVendido(id);
        }

    }
}
