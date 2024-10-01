using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDesafio.Clases
{
    public class Usuario
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        private string Mail { get; set; }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }

        public int GetId() {  return Id; }
        public string GetNombre() { return Nombre; }
        public string GetApellido() { return Apellido; }
        public string GetNombreUsuario() { return NombreUsuario; }
        public string GetContraseña() { return Contraseña; }
        public string GetMail() { return Mail; }


    }

}
