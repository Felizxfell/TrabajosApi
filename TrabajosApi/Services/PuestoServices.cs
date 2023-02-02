using TrabajosApi.Context;
using TrabajosApi.Models;

namespace TrabajosApi.Services
{
    public class PuestoServices : IPuestoServices
    {
        private readonly TrabajosDbContext _context;

        public PuestoServices (TrabajosDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<CatPuesto> Get()
        {
            return _context.CatPuestos.OrderBy(r => r.Nombre);
        }
    }

    public interface IPuestoServices
    {
        IEnumerable<CatPuesto> Get();
    }
}
