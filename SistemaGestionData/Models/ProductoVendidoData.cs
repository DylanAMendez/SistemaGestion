﻿using SistemaGestionData.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaGestionData.Models
{
    public class ProductoVendidoData
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Id del Producto es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del Producto debe ser mayor que 0.")]
        [Display(Name = "Id del Producto")]
        [JsonPropertyName("IdProducto")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El campo Stock es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a 0.")]
        [JsonPropertyName("stock")]
        public int stock { get; set; }

        [JsonPropertyName("IdVenta")]
        public int IdVenta { get; set; }
    }
}
