using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabajoIntegrador.Entities;
using TrabajoIntegrador.DTOs;

namespace TrabajoIntegrador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        [HttpGet]
        [Route("Servicios")]
        public IActionResult Servicios()
        {
            return Ok("Todos los servicios");
        }


        [HttpPost]
        [Route("Agregar")]
        public IActionResult AgregarServicio(ServicioDto servicio)
        {
            return Unauthorized("No se pudo agregar servicio");
        }


        [HttpPut]
        [Route("Editar")]
        public IActionResult EditarServicio(ServicioDto servicio)
        {
            return Ok(servicio);
        }


        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarServicio(int id)
        {
            return Ok($"Se elimino el elemento {id} correctamente");  
        }
    }
}
