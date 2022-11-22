using Microsoft.AspNetCore.Mvc;
using PokemonPOO.Entidades;
using PokemonPOO.Servicios;

namespace PokemonPOO.API.Controllers
{
    [ApiController]
    [Route("api/campos-de-batalla")]
    public class CampoDeBatallaController : ControllerBase
    {
        DataServices dataServices = new DataServices();

        [HttpGet]
        [Route("todos")]
        public List<CampoDeBatalla> obtenerTodos()
        {
            return dataServices.getCamposDeBatalla();
        }

        [HttpGet]
        [Route("{id}")]
        public CampoDeBatalla obtenerPorId(int id)
        {
            return dataServices.getCampoDeBatallaPorId(id);
        }


        [HttpGet]
        [Route("{id}/batalla")]
        public ResultadoBatalla obtenePorId(int id)
        {
            CampoDeBatalla campoDeBatalla = dataServices.getCampoDeBatallaPorId(id);
            return dataServices.getResultadoDeBatalla(campoDeBatalla);
        }

        [HttpGet]
        [Route("{idCampoBatalla}/pokemones/set/{idPokemon1}/{idPokemon2}")]
        public List<Pokemon> setPokemones(int idCampoBatalla,int idPokemon1, int idPokemon2)
        {
            CampoDeBatalla campoDeBatalla = dataServices.getCampoDeBatallaPorId(idCampoBatalla);
            dataServices.setPokemonesBatalla(idPokemon1, idPokemon2);
            campoDeBatalla = dataServices.getCampoDeBatallaPorId(idCampoBatalla);
            return campoDeBatalla.pokemones;
        }

        //seleccionar pokemones para la batalla ?
        //{idCampoBatalla}/pokemones/todos ?¿
        //{idCampoBatalla}/pokemones/agregar ?¿
        //{idCampoBatalla}/pokemones/limpiar ?¿
    }
}
