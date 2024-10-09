using ClaseDesafio.Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionData.Models;

namespace SistemasGestionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly UsuarioBussiness _usuarioBussiness;

        public UsuarioController(ILogger<ProductosController> logger, UsuarioBussiness usuarioBussiness)
        {
            this._logger = logger;
            this._usuarioBussiness = usuarioBussiness;
        }

        [HttpGet(Name = "Get Usuarios")]
        public ActionResult<List<UsuarioData>> GetUsuarios()
        {
            return _usuarioBussiness.ObtenerUsuarios();
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioData> GetUnUsuario(int id)
        {
            var usuario = _usuarioBussiness.ObtenerUnUsuario(id);

            if (usuario is null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpPost]
        public ActionResult<UsuarioData> CrearUsuario([FromBody] UsuarioData usuario)
        {
            var usuarioCreado = _usuarioBussiness.CrearUsuario(usuario);
            return CreatedAtAction(nameof(CrearUsuario), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public ActionResult ModificarUsuario([FromRoute(Name = "id")] int id, [FromBody] UsuarioData usuario)
        {
            _usuarioBussiness.ModificarUsuario(id, usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUsuario([FromRoute(Name = "id")] int id)
        {
            _usuarioBussiness.EliminarUsuario(id);
            return NoContent();
        }


    }
}
