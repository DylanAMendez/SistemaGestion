using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData.Models;
using SistemaGestionData.Contexts;

namespace SistemaGestionData.Database
{
    public class ProductoDataAccess
    {
        private static CoderhouseDbContext _context = new CoderhouseDbContext();

        public ProductoDataAccess()
        {
            _context = new CoderhouseDbContext();
        }

        public static List<ProductoData> ListarProductos()
        {
            try
            {
                return _context.Productos.ToList();
            }
            catch
            {
                return new List<ProductoData>();
            }
        }

        public static ProductoData? ObtenerProducto(int idABuscar)
        {
            try
            {
                return _context.Productos.Where(k => k.Id == idABuscar).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public static ProductoData CrearProducto(ProductoData nuevoProducto)
        {
            try
            {
                _context.Productos.Add(nuevoProducto);
                _context.SaveChanges();

                return nuevoProducto;
            }
            catch
            {
                return null;
            }
        }

        public static ProductoData ModificarProducto(int idABuscar, ProductoData actualizarProducto)
        {
            try
            {
                var productoExistente = _context.Productos.Where(k => k.Id == idABuscar).FirstOrDefault();

                if (productoExistente == null)
                {
                    return null;
                }

                productoExistente.Descripcion = actualizarProducto.Descripcion;
                productoExistente.PrecioCompra = actualizarProducto.PrecioCompra;
                productoExistente.PrecioVenta = actualizarProducto.PrecioVenta;
                productoExistente.Stock = actualizarProducto.Stock;
                productoExistente.TotalProducto = actualizarProducto.TotalProducto;
                productoExistente.Categoria = actualizarProducto.Categoria;

                _context.SaveChanges();

                return productoExistente;
            }
            catch
            {
                return null;
            }

        }

        public static ProductoData EliminarProducto(int id)
        {
            try
            {
                var productoAEliminar = _context.Productos.FirstOrDefault(k => k.Id == id);

                if (productoAEliminar == null)
                {
                    return null;
                }

                _context.Productos.Remove(productoAEliminar);
                _context.SaveChanges();

                return productoAEliminar;
            }
            catch
            {
                return null;
            }    

        }

    }
}
