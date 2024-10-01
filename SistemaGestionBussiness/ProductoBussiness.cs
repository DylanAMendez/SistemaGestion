using SistemaGestionData.Database;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<ProductoData> GetProductos()
        {
            return ProductoDataAccess.ListarProductos();
        }        
        public static ProductoData? ObtenerUnProducto(int id)
        {
            return ProductoDataAccess.ObtenerProducto(id);
        }    
        public static ProductoData CrearUnProducto(ProductoData producto)
        {
            return ProductoDataAccess.CrearProducto(producto);
        }     
        public static ProductoData ModificarUnProducto(int id, ProductoData producto)
        {
            return ProductoDataAccess.ModificarProducto(id, producto);
        }        
        public static ProductoData EliminarUnProducto(int id)
        {
            return ProductoDataAccess.EliminarProducto(id);
        }


    }
}
