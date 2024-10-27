using SistemaGestionData.Contexts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SistemaGestionData.Models
{
    public class UsuarioData
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [MaxLength(100, ErrorMessage = "El Nombre no puede tener más de 100 caracteres.")]
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Apellido es requerido.")]
        [MaxLength(100, ErrorMessage = "El Apellido no puede tener más de 100 caracteres.")]
        [JsonPropertyName("apellido")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Nombre de Usuario es requerido.")]
        [MaxLength(100, ErrorMessage = "El Nombre de Usuario no puede tener más de 100 caracteres.")]
        [JsonPropertyName("NombreUsuario")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Contraseña es requerido.")]
        [MaxLength(100, ErrorMessage = "La Contraseña no puede tener más de 100 caracteres.")]
        [MinLength(5, ErrorMessage = "La Contraseña debe tener al menos 5 caracteres.")]
        [JsonPropertyName("contraseña")]
        public string Contraseña { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Email es requerido.")]
        [MaxLength(100, ErrorMessage = "El Email no puede tener más de 100 caracteres.")]
        [EmailAddress(ErrorMessage = "El Email no es una dirección de correo electrónico válida.")]
        [JsonPropertyName("email")]
        public string? Email { get; set; } = string.Empty;
    }
}
