using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDesafio.Clases
{
    public class Producto
    {
        private int Id { get; set; }
        private string Descripcion { get; set; }
        private int Costo { get; set; }
        private int PrecioVenta { get; set; }
        private int Stock { get; set; }
        private int IdUsuario { get; set; }

        public Producto(int id, string descripcion, int costo, int precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

        public int GetId() { return Id; }
        public string GetDescripcion() { return Descripcion; }
        public int GetCosto() { return Costo; }
        public int GetPrecioVenta() { return PrecioVenta; }
        public int GetStock() { return Stock; }
        public int GetIdUsuario() { return IdUsuario; }

    }

}
