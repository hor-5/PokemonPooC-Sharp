using PokemonPOO.Datastore;
using PokemonPOO.Entidades;

namespace PokemonPOO.Servicios
{
    public class DataServices
    {
        DataStorage dataStorage = new DataStorage();
        public List<Tipo> getTipos()
        {
            return dataStorage.GetTipos();
        }

        public List<Pokemon> getPokemones()
        {
            return dataStorage.GetPokemones();
        }

        public Pokemon getPokemonById(int id)
        {
            Pokemon result = null;
            List<Pokemon> aPokemones = dataStorage.GetPokemones();
            foreach (Pokemon pokemon in aPokemones)
            {
                if (pokemon.idPokemon == id)
                {
                    result = pokemon;
                }
            }
            return result;
        }
        public List<EntrenadorPokemon> getEntrenadoresPokemon()
        {
            return dataStorage.GetEntrenadoresPokemon();
        }

        public EntrenadorPokemon getEntrenadorById(int id)
        {
            EntrenadorPokemon result = null;
            List<EntrenadorPokemon> aEntrenadores = dataStorage.GetEntrenadoresPokemon();
            foreach (EntrenadorPokemon entrenador in aEntrenadores)
            {
                if (entrenador.idEntrenador == id)
                {
                    result = entrenador;
                }
            }
            return result;
        }
        public List<CampoDeBatalla> getCamposDeBatalla()
        {
            return dataStorage.GetCamposDeBatalla();
        }

        public CampoDeBatalla getCampoDeBatallaPorId(int id)
        {
            CampoDeBatalla result = null;
            List<CampoDeBatalla> aCampos = dataStorage.GetCamposDeBatalla();
            foreach (CampoDeBatalla campo in aCampos)
            {
                if (campo.idCampoDeBatalla == id)
                {
                    result = campo;
                }
            }
            return result;
        }

        public ResultadoBatalla getResultadoDeBatalla(CampoDeBatalla campoDeBatalla)
        {
            ResultadoBatalla resultadoBatalla = null;
            return campoDeBatalla.comenzarBatalla();
        }
    }
}