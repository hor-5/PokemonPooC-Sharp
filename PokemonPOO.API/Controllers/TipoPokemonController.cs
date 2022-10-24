using Microsoft.AspNetCore.Mvc;
using PokemonPOO.Entidades;
using PokemonPOO.Servicios;

namespace PokemonPOO.API.Controllers
{
    [ApiController]
    [Route("tipos-pokemon")]
    public class TipoPokemonController : ControllerBase
    {

        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<Tipo> obtenerTodos(){
            return dataServices.getTipos();
        }
        
    }
}
