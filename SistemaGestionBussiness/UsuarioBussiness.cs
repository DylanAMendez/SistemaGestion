using SistemaGestionData.Database;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<UsuarioData> ObtenerUsuarios()
        {
            return UsuarioDataAcces.ObtenerUsuario();
        }        
        public static UsuarioData ObtenerUnUsuario(int id)
        {
            return UsuarioDataAcces.ListarUsuarios(id);
        }      
        public static UsuarioData ModificarUsuario(int id, UsuarioData usuarioData)
        {
            return UsuarioDataAcces.ModificarUsuario(id, usuarioData);
        }        
        public static UsuarioData CrearUsuario(UsuarioData usuarioData)
        {
            return UsuarioDataAcces.CrearUsuario(usuarioData);
        }       
        public static UsuarioData EliminarUsuario(int id)
        {
            return UsuarioDataAcces.EliminarUsuario(id);
        }



    }
}
