using GestionAdministrativaBarracas.Dominio;
using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace GestionAdministrativa.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SociosController : ControllerBase
    {
        private readonly ISocioRepository _repo;

        public SociosController(ISocioRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var socios = _repo.ObtenerTodos();
            return Ok(socios);
        }
    
    [HttpPost]
        public IActionResult Crear([FromBody] Socio socio)
        {
            _repo.Agregar(socio);
            return Ok();
        }
    }
}