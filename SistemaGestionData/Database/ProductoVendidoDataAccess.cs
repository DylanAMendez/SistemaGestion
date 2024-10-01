using SistemaGestionData.Contexts;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Database
{
    public class ProductoVendidoDataAccess
    {
        private static CoderhouseDbContext _context = new CoderhouseDbContext();
        public ProductoVendidoDataAccess()
        {
            _context = new CoderhouseDbContext();
        }

        public static List<ProductoVendidoData> ObtenerProductoVendidos()
        {
            return _context.ProductosVendidos.ToList();
        }

        public static ProductoVendidoData? ListarProductoVendido(int idABuscar)
        {
            return _context.ProductosVendidos.Where(k => k.Id == idABuscar).FirstOrDefault();
        }

        public static ProductoVendidoData CrearProductoVendido(ProductoVendidoData nuevoProducto)
        {
            _context.ProductosVendidos.Add(nuevoProducto);
            _context.SaveChanges();

            return nuevoProducto;
        }

        public static ProductoVendidoData ModificarProductoVendido(int idABuscar, ProductoVendidoData VentaDataProducto)
        {
            var VentaDataExistente = _context.ProductosVendidos.Where(k => k.Id == idABuscar).FirstOrDefault();

            if (VentaDataExistente == null)
            {
                return null;
            }

            VentaDataExistente.stock = VentaDataProducto.stock;

            _context.SaveChanges();

            return VentaDataExistente;

        }

        public static ProductoVendidoData EliminarProductoVendido(int id)
        {
            var VentaDataAEliminar = _context.ProductosVendidos.FirstOrDefault(k => k.Id == id);

            if (VentaDataAEliminar == null)
            {
                return null;
            }

            _context.ProductosVendidos.Remove(VentaDataAEliminar);
            _context.SaveChanges();

            return VentaDataAEliminar;

        }

    }
}
