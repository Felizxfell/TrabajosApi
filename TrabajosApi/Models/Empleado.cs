using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajosApi.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PuestoId { get; set; }
        public virtual CatPuesto Puesto { get; set; }
    }

    public class EmpleadoGetSP
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PuestoId { get; set; }
        public string Puesto { get; set; }
    }

    public class EmpleadoRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PuestoId { get; set; }
    }

    public class EmpleadoRequestPut
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PuestoId { get; set; }
    }
}