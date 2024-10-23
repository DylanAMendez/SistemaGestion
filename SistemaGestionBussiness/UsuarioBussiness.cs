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
        public List<UsuarioData> ObtenerUsuarios()
        {
            return UsuarioDataAcces.ObtenerUsuario();
        }        
        public UsuarioData ObtenerUnUsuario(int id)
        {
            return UsuarioDataAcces.ListarUsuarios(id);
        }
        public UsuarioData ListarUsuariosQueContenganFiltro(string usuarioABuscar)
        {
            return UsuarioDataAcces.ListarUsuariosQueContenganFiltro(usuarioABuscar);
        }

        public UsuarioData ModificarUsuario(int id, UsuarioData usuarioData)
        {
            return UsuarioDataAcces.ModificarUsuario(id, usuarioData);
        }        
        public UsuarioData CrearUsuario(UsuarioData usuarioData)
        {
            return UsuarioDataAcces.CrearUsuario(usuarioData);
        }       
        public UsuarioData EliminarUsuario(int id)
        {
            return UsuarioDataAcces.EliminarUsuario(id);
        }



    }
}
