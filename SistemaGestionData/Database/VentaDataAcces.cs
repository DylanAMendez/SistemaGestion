using SistemaGestionData.Contexts;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Database
{
    public class VentaDataAcess
    {
        private static CoderhouseDbContext _context = new CoderhouseDbContext();

        public VentaDataAcess()
        {
            _context = new CoderhouseDbContext();
        }

        public static List<VentaData> ObtenerVenta()
        {
            try
            {
                return _context.Ventas.ToList();
            }
            catch
            {
                return new List<VentaData>();
            }
        }

        public static VentaData? ListarVentas(int idABuscar)
        {
            try
            {
                return _context.Ventas.Where(k => k.Id == idABuscar).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public static VentaData CrearVenta(VentaData nuevaVenta)
        {
            try
            {
                _context.Ventas.Add(nuevaVenta);
                _context.SaveChanges();

                return nuevaVenta;
            }
            catch
            {
                return null;
            }
        }

        public static VentaData ModificarVenta(int idABuscar, VentaData venta)
        {
            try
            {
                var VentaDataExistente = _context.Ventas.Where(k => k.Id == idABuscar).FirstOrDefault();

                if (VentaDataExistente == null)
                {
                    return null;
                }

                VentaDataExistente.comentario = venta.comentario;

                _context.SaveChanges();

                return VentaDataExistente;
            }
            catch
            {
                return null;
            }
        }

        public static VentaData EliminarVenta(int id)
        {
            try
            {
                var VentaDataAEliminar = _context.Ventas.FirstOrDefault(k => k.Id == id);

                if (VentaDataAEliminar == null)
                {
                    return null;
                }

                _context.Ventas.Remove(VentaDataAEliminar);
                _context.SaveChanges();

                return VentaDataAEliminar;
            }
            catch
            {
                return null;
            }

        }

    }
}
