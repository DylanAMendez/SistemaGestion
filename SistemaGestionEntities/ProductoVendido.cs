using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDesafio.Clases
{
    public class ProductoVendido
    {
        private int Id { set; get; }
        private int IdProducto { set; get; }
        private int Stock { set; get; }
        private int IdVenta { set; get; }


        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }

        public int GetId() { return Id; }
        public int GetIdProducto() { return IdProducto; }
        public int GetStock() { return Stock; }
        public int GetIdVenta() { return IdVenta; }


    }
}
