using SistemaGestionData.Database;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public List<ProductoData> GetProductos()
        {
            return ProductoDataAccess.ListarProductos();
        }        
        public ProductoData? ObtenerUnProducto(int id)
        {
            return ProductoDataAccess.ObtenerProducto(id);
        }    
        public ProductoData CrearUnProducto(ProductoData producto)
        {
            return ProductoDataAccess.CrearProducto(producto);
        }     
        public ProductoData ModificarUnProducto(int id, ProductoData producto)
        {
            return ProductoDataAccess.ModificarProducto(id, producto);
        }        
        public ProductoData EliminarUnProducto(int id)
        {
            return ProductoDataAccess.EliminarProducto(id);
        }


    }
}
