namespace PokemonPOO.Entidades
{
    public class EntrenadorPokemon
    {
        public int idEntrenador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string imgUrl { get; set; }
        public Pokedex pokedex { get; set; }
        public List<Pokemon> aPokemones { get; set; }


        private Pokemon buscarPokemon(string nombrePokemon)
        {
            Pokemon pokemonSeleccionado = null;
            foreach (Pokemon pokemon in aPokemones)
            {

                if (pokemon.nombre == nombrePokemon)
                {
                    pokemonSeleccionado = pokemon;
                }

            }
            if (pokemonSeleccionado == null)
            {
                Console.WriteLine($"{nombre} {apellido} no tiene a {nombrePokemon}");
            }

            return pokemonSeleccionado;
        }

        public Pokemon elegirPokemon(string nombrePokemon)
        {
            return buscarPokemon(nombrePokemon);
        }

        public Pokemon elegirPokemon(Tipo tipo)
        {
            Pokemon pokemonSeleccionado = null;
            foreach (Pokemon pokemon in aPokemones)
            {
                if (tipo.nombreTipo == pokemon.tipoPrincipal.nombreTipo)
                {
                    pokemonSeleccionado = pokemon;
                    break;
                }
            }
            return pokemonSeleccionado;
        }

        public void entrenarPokemon(string nombrePokemon)
        {
            Pokemon pokemonSeleccionado = buscarPokemon(nombrePokemon);
            if (pokemonSeleccionado != null)
            {
                pokemonSeleccionado.entrenar();
            }
        }

        public void entrenarPokemon(Pokemon pokemon, int intensidad = 1)
        {
            if (aPokemones.Contains(pokemon))
            {
                Pokemon pokemonSeleccionado = aPokemones[aPokemones.IndexOf(pokemon)];
                pokemonSeleccionado.entrenar(intensidad);
            }
            else
            {
                Console.WriteLine($"el entrenador no tiene a {pokemon.nombre}");
            }
        }

        public void verPokemones()
        {
            Console.WriteLine($"\nLos pokemones de {nombre} son: ");
            foreach (Pokemon pokemon in aPokemones)
            {
                Console.WriteLine($"{pokemon.nombre.ToUpper()} - nivel:{pokemon.nivel}");
            }
        }




    }
}
