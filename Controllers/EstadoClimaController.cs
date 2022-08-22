using Microsoft.AspNetCore.Mvc;

namespace TheGym.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadoClimaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<EstadoClimaController> _logger;

        public EstadoClimaController(ILogger<EstadoClimaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("ÚsuariosEjemplo")]
        public IActionResult Get()
        {
            var usuario1 = new Usuario { Nombre = "Pedro", Apellido = "Carcamo" };
            var usuario2 = new Usuario { Nombre = "Andrea", Apellido = "Bonilla" };

            List<Usuario> usuariosJuntos = new List<Usuario>();
            usuariosJuntos.Add(usuario1);
            usuariosJuntos.Add(usuario2);
            return Ok("Hola");

        }


        [HttpGet]
        [Route("ClimaSPS")]
        public IActionResult DevolverClimaSPS()
        {
            return Ok("Esta caliente");
        }
    }
}