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
    public class ProductoData
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Descripción es requerido.")]
        [MaxLength(250, ErrorMessage = "La Descripción no puede tener más de 50 caracteres.")]
        [MinLength(5, ErrorMessage = "La Descripción debe tener al menos 5 caracteres.")]
        [Display(Name = "Descripción")]
        [JsonPropertyName("descripcion")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Precio de Compra es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Precio de Compra debe ser mayor o igual a 0.")]
        [Display(Name = "Precio de Compra")]
        [JsonPropertyName("precioCompra")]
        public decimal PrecioCompra { get; set; }

        [Required(ErrorMessage = "El campo Precio de Venta es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Precio de Venta debe ser mayor o igual a 0.")]
        [Display(Name = "Precio de Venta")]
        [JsonPropertyName("precioVenta")]
        public decimal PrecioVenta { get; set; }

        [Required(ErrorMessage = "El campo Stock es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a 0.")]
        [JsonPropertyName("stock")]
        public decimal Stock { get; set; }

        [Required(ErrorMessage = "El campo Total de Producto es requerido.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Total de Producto debe ser mayor o igual a 0.")]
        [Display(Name = "Total de Producto")]
        [JsonPropertyName("totalProducto")]
        public decimal TotalProducto { get; set; }

        [Required(ErrorMessage = "El campo Categoría es requerido.")]
        [MaxLength(50, ErrorMessage = "La Categoría no puede tener más de 50 caracteres.")]
        [MinLength(5, ErrorMessage = "La Categoría debe tener al menos 5 caracteres.")]
        [JsonPropertyName("categoria")]
        public string? Categoria { get; set; } = string.Empty;

    }
}
