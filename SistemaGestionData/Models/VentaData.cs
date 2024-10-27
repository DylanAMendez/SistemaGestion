using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaGestionData.Models
{
    public class VentaData
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Comentario es requerido.")]
        [MaxLength(50, ErrorMessage = "El comentario no puede tener más de 50 caracteres.")]
        [MinLength(5, ErrorMessage = "El comentario debe tener al menos 5 caracteres.")]
        [JsonPropertyName("comentario")]
        public string comentario { get; set; }

        [Required(ErrorMessage = "El campo Id del Usuario es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del Usuario debe ser mayor que 0.")]
        [Display(Name = "Id del Usuario")]
        [JsonPropertyName("IdUsuario")]
        public int IdUsuario { get; set; }

        [NotMapped]
        public List<ProductoVendidoData>? ProductosVendidos { get; set; } = new List<ProductoVendidoData>();
    }
}
