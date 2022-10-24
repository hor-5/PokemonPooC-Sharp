using Microsoft.AspNetCore.Mvc;
using PokemonPOO.Entidades;
using PokemonPOO.Servicios;

namespace PokemonPOO.API.Controllers
{
    [ApiController]
    [Route("entrenadores")]
    public class EntrenadoresController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<EntrenadorPokemon> obtenerTodos() {
            return dataServices.getEntrenadoresPokemon();
        }
    }
}
