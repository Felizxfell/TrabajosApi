namespace TrabajosApi.Models
{
    public class CatPuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
