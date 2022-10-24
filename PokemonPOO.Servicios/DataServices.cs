using PokemonPOO.Datastore;
using PokemonPOO.Entidades;

namespace PokemonPOO.Servicios
{
    public class DataServices
    {
        DataStorage dataStorage = new DataStorage();
        public List<Tipo> getTipos() {
            return dataStorage.GetTipos();
        }

        public List<Pokemon> getPokemones() {
            return dataStorage.GetPokemones();
        }

        public List<EntrenadorPokemon> getEntrenadoresPokemon() {
            return dataStorage.GetEntrenadoresPokemon();
        }

        public List<CampoDeBatalla> getCamposDeBatalla() { 
            return dataStorage.GetCamposDeBatalla();
        }

    }
}