using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClaseDesafio.Clases
{
    public class Venta
    {
        private int Id { get; set; }
        private string Comentarios { set; get; }
        private int IdUsuario { set; get; }

        public Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;

        }

        public int GetId() { return Id; }
        public string GetComentarios() { return Comentarios; }
        public int GetIdUsuario() { return IdUsuario; }

    }
}
