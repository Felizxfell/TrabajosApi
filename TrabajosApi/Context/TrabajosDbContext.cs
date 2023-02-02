using Microsoft.EntityFrameworkCore;
using TrabajosApi.Models;

namespace TrabajosApi.Context
{
    public class TrabajosDbContext : DbContext
    {
        public TrabajosDbContext(DbContextOptions<TrabajosDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<CatPuesto> CatPuestos { get; set; }
        public DbSet<EmpleadoGetSP> EmpleadoGet { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<CatPuesto> catPuestos = new List<CatPuesto>
            {
                new CatPuesto() { Id = 1, Nombre = "Director" },
                new CatPuesto() { Id = 2, Nombre = "Desarrollador" },
                new CatPuesto() { Id = 3, Nombre = "Diseñador" },
                new CatPuesto() { Id = 4, Nombre = "Técnico" },
                new CatPuesto() { Id = 5, Nombre = "Tester" },
                new CatPuesto() { Id = 6, Nombre = "Soporte" },
                new CatPuesto() { Id = 7, Nombre = "Analista" }
            };

            modelBuilder.Entity<CatPuesto>().HasData(catPuestos);
        }
    }
}
