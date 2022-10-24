using Microsoft.AspNetCore.Mvc;
using PokemonPOO.Entidades;
using PokemonPOO.Servicios;

namespace PokemonPOO.API.Controllers
{   
    [ApiController]
    [Route("pokemon")]
    public class PokemonController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<Pokemon> obtenerTodos() { 
            return dataServices.getPokemones();
        }
    }
}
