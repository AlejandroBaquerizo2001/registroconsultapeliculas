using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using registroconsultapeliculas.Entidades;
using registroconsultapeliculas.Repositorio;

namespace Apiregistroconsulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        private readonly IRepositorioDatos _repositorioDatos;

        public DatosController(IRepositorioDatos repositorioDatos)
        {
            _repositorioDatos = repositorioDatos;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var lista = await _repositorioDatos.ObtenerTodos();
                return Ok(lista);
            }
            catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var datos = await _repositorioDatos.ObtenerPorId(id);
                return Ok(datos);
            }
            catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult>Post(Datos datos)
        {
            try
            {
                var id = await _repositorioDatos.Crear(datos);
                return Ok(id);
            }
            catch (Exception ex)  
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
