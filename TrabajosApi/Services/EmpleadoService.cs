using Microsoft.EntityFrameworkCore;
using System;
using TrabajosApi.Context;
using TrabajosApi.Models;

namespace TrabajosApi.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly TrabajosDbContext _context;

        public EmpleadoService(TrabajosDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EmpleadoGetSP> Get()
        {
            return _context.EmpleadoGet
                .FromSql($"sp_GetEmpleados")
                .ToList();
        }

        public IEnumerable<EmpleadoGetSP> GetById(int id)
        {
            return _context.EmpleadoGet
                .FromSql($"sp_GetEmpleados {id}")
                .ToList();
        }

        public async Task<int> Save(EmpleadoRequest empleado)
        {
            return await _context.Database
                .ExecuteSqlInterpolatedAsync($"sp_InsertEmpleados {empleado.Nombre}, {empleado.Apellido}, {empleado.PuestoId}");
        }

        public Task<int> Update(EmpleadoRequestPut empleado)
        {
            return _context.Database
                .ExecuteSqlInterpolatedAsync($"sp_UpdateEmpleados {empleado.EmpleadoId}, {empleado.Nombre}, {empleado.Apellido}, {empleado.PuestoId}");
        }

        public Task<int> Delete(int id)
        {
            return _context.Database
                .ExecuteSqlInterpolatedAsync($"sp_DeleteEmpleados {id}");
        }
    }

    public interface IEmpleadoService
    {
        IEnumerable<EmpleadoGetSP> Get();
        IEnumerable<EmpleadoGetSP> GetById(int id);
        Task<int> Save(EmpleadoRequest empleado);
        Task<int> Update(EmpleadoRequestPut empleado);
        Task<int> Delete(int id);
    }
}
