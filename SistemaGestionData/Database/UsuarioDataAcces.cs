using SistemaGestionData.Contexts;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Database
{
    public class UsuarioDataAcces
    {
        private static CoderhouseDbContext _context = new CoderhouseDbContext();

        public UsuarioDataAcces()
        {
            _context = new CoderhouseDbContext();
        }

        public static List<UsuarioData> ObtenerUsuario()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch
            {
                return new List<UsuarioData>();
            }
        }

        public static UsuarioData? ListarUsuarios(int idABuscar)
        {
            try
            {
                return _context.Usuarios.Where(k => k.Id == idABuscar).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public static UsuarioData? ListarUsuariosQueContenganFiltro(string stringABuscar)
        {
            try
            {
                return _context.Usuarios.Where(k => k.NombreUsuario.Contains(stringABuscar) || k.Email.Contains(stringABuscar)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public static UsuarioData CrearUsuario(UsuarioData nuevoUsuario)
        {
            try
            {
                _context.Usuarios.Add(nuevoUsuario);
                _context.SaveChanges();

                return nuevoUsuario;
            }
            catch
            {
                return null;
            }
        }

        public static UsuarioData ModificarUsuario(int idABuscar, UsuarioData usuario)
        {
            try
            {
                var usuarioDataExistente = _context.Usuarios.Where(k => k.Id == idABuscar).FirstOrDefault();

                if (usuarioDataExistente == null)
                {
                    return null;
                }

                usuarioDataExistente.Nombre = usuario.Nombre;
                usuarioDataExistente.Apellido = usuario.Apellido;
                usuarioDataExistente.NombreUsuario = usuario.NombreUsuario;
                usuarioDataExistente.Contraseña = usuario.Contraseña;
                usuarioDataExistente.Email = usuario.Email;

                _context.SaveChanges();

                return usuarioDataExistente;
            }
            catch
            {
                return null;
            }
        }

        public static UsuarioData EliminarUsuario(int id)
        {
            try
            {
                var usuarioDataAEliminar = _context.Usuarios.FirstOrDefault(k => k.Id == id);

                if (usuarioDataAEliminar == null)
                {
                    return null;
                }

                _context.Usuarios.Remove(usuarioDataAEliminar);
                _context.SaveChanges();

                return usuarioDataAEliminar;
            }
            catch
            {
                return null;
            }

        }

    }
}
