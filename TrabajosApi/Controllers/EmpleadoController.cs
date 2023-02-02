using Microsoft.AspNetCore.Mvc;
using TrabajosApi.Models;
using TrabajosApi.Services;

namespace TrabajosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_empleadoService.Get());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_empleadoService.GetById(id));
        }

        [HttpPost]
        public async Task<int> Post([FromBody] EmpleadoRequest empleado)
        {
            return await _empleadoService.Save(empleado);
        }

        [HttpPut]
        public async Task<int> Put([FromBody] EmpleadoRequestPut empleado)
        {
            return await _empleadoService.Update(empleado);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await _empleadoService.Delete(id);
        }
    }
}
