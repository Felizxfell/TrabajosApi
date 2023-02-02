using Microsoft.AspNetCore.Mvc;
using TrabajosApi.Services;

namespace TrabajosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PuestoController : ControllerBase
    {
        private readonly IPuestoServices _puestoServices;

        public PuestoController(IPuestoServices puestoServices)
        {
            _puestoServices = puestoServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_puestoServices.Get());
        }
    }
}
