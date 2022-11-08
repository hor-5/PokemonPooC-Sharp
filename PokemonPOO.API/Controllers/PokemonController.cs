using Microsoft.AspNetCore.Mvc;
using PokemonPOO.Entidades;
using PokemonPOO.Servicios;

namespace PokemonPOO.API.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<Pokemon> obtenerTodos()
        {
            return dataServices.getPokemones();
        }

        [HttpGet]
        [Route("{id}")]
        public Pokemon obtenerPorId(int id)
        {
            return dataServices.getPokemonById(id);
        }
    }
}
