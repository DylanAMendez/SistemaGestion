using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData.Models;

namespace SistemaGestionData.Contexts
{
    public class CoderhouseDbContext : DbContext
    {
        //tablas de la bd
        public DbSet<ProductoData> Productos { get; set; }
        public DbSet<UsuarioData> Usuarios {  get; set; }
        public DbSet<VentaData> Ventas {  get; set; }
        public DbSet<ProductoVendidoData> ProductosVendidos {  get; set; }

        public CoderhouseDbContext() : base(){ }

        //conexion a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DJLPQ92;Initial Catalog=CoderhouseProyectoFinal;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
