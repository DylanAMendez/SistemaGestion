using SistemaGestionData.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Models
{
    public class ProductoVendidoData
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int stock { get; set; }
        public int IdVenta { get; set; }
    }
}
