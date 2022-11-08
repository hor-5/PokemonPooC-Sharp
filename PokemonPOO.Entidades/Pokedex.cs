namespace PokemonPOO.Entidades
{
    public class Pokedex
    {
        public int idPokedex { get; set; }
        public List<Pokemon> pokemonesRegistrados { get; set; }

        public void mostrarInfoPokemon(Pokemon pokemon)
        {
            pokemon.setImagenASCII(pokemon);
            Console.WriteLine(pokemon.getImagenASCII());
            Console.WriteLine($"información sobre {pokemon.nombre} :");
            Console.WriteLine($"\n {pokemon.descripcion}\n");
        }

        public void registrarPokemon(Pokemon pokemon)
        {
            Console.WriteLine($"\nBuscando a {pokemon.nombre.ToUpper()} en la pokedex");
            mostrarInfoPokemon(pokemon);
            pokemonesRegistrados.Add(pokemon);
            Console.WriteLine($"{pokemon.nombre} registrado!");
        }


    }
}
