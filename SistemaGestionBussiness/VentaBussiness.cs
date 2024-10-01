using SistemaGestionData.Database;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public List<VentaData> ObtenerVentas()
        {
            return VentaDataAcess.ObtenerVenta();
        }     
        public VentaData ObtenerUnaVenta(int id)
        {
            return VentaDataAcess.ListarVentas(id);
        }
        public VentaData ModificarVenta(int id, VentaData ventaData)
        {
            return VentaDataAcess.ModificarVenta(id, ventaData);
        }
        public VentaData EliminarVenta(int id)
        {
            return VentaDataAcess.EliminarVenta(id);
        }
        public VentaData CrearVenta(VentaData ventaData)
        {
            return VentaDataAcess.CrearVenta(ventaData);
        }


    }
}
