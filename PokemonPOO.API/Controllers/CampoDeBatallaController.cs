using Microsoft.AspNetCore.Mvc;
using PokemonPOO.Entidades;
using PokemonPOO.Servicios;

namespace PokemonPOO.API.Controllers
{
    [ApiController]
    [Route("campos-de-batalla")]
    public class CampoDeBatallaController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<CampoDeBatalla> obtenerTodos() {
            return dataServices.getCamposDeBatalla();
        }

    }
}
