using SistemaGestionData.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Models
{
    public class ProductoData
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Stock { get; set; }
        public decimal TotalProducto { get; set; }
        public string? Categoria { get; set; }

    }
}
