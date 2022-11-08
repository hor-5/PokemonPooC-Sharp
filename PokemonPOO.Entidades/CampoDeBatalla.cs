namespace PokemonPOO.Entidades
{
    public class CampoDeBatalla
    {
        public int idCampoDeBatalla { get; set; }
        public string nombre { get; set; }
        public string localizacion { get; set; }
        public List<Pokemon> pokemones { get; set; }

        public void getPokemonesEnBatalla()
        {
            foreach (Pokemon pokemon in pokemones)
            {
                Console.WriteLine(pokemon.nombre);
            }
        }

        public ResultadoBatalla comenzarBatalla()
        {
            ResultadoBatalla resultadoBatalla = null;

            if (pokemones.Count > 1)
            {
                Pokemon pokemon1 = pokemones[0];
                Pokemon pokemon2 = pokemones[1];
                Console.WriteLine($"\nComenzando la batalla entre {pokemon1.nombre.ToUpper()} y {pokemon2.nombre.ToUpper()}");
                Random random = new Random();
                bool batalla = true;
                while (batalla)
                {
                    int numAleatorio = random.Next(1, 5);// numero aleatorio entre 1 y 4,
                    //primer pokemon ataca
                    pokemon1.atacar(pokemon2);
                    //Thread.Sleep(2000);
                    //defensa aleatoria
                    if (numAleatorio == 1 || numAleatorio == 3 && pokemon2.salud > pokemon2.capacidadDefensa)
                    {
                        pokemon2.defenderse();
                        //Thread.Sleep(2000);
                    }
                    //segundo pokemon ataca
                    pokemon2.atacar(pokemon1);
                    //Thread.Sleep(2000);
                    //defensa aleatoria
                    if (numAleatorio == 2 || numAleatorio == 4 && pokemon1.salud > pokemon1.capacidadDefensa)
                    {
                        pokemon1.defenderse();
                        //Thread.Sleep(2000);
                    }

                    //chequeamos si algún pokemon se quedó sin salud
                    if (pokemon1.salud <= 0 || pokemon2.salud <= 0)
                    {
                        batalla = false;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in pokemones)
                        {
                            Console.WriteLine($"\n{pokemon.nombre.ToUpper()} : {pokemon.salud} salud ");
                        }
                    }

                }

                mostrarGanador(pokemon1, pokemon2);
                resultadoBatalla = new ResultadoBatalla
                {
                    ganador = (pokemon1.salud > 0) ? pokemon1 : pokemon2,
                    perdedor = (pokemon1.salud <= 0) ? pokemon1 : pokemon2
                };

            }
            else
            {
                Console.WriteLine("Se necesitan dos pokemones para poder batallar!");
            }
            return resultadoBatalla;
        }

        private void mostrarGanador(Pokemon pokemon1, Pokemon pokemon2)
        {
            Pokemon pokemonGanador = (pokemon1.salud > 0) ? pokemon1 : pokemon2;
            //Thread.Sleep(1000);
            Console.WriteLine("\nBatalla finalizada!");
            Console.WriteLine($"\nEl ganador es {pokemonGanador.nombre}, resistió quedando con {pokemonGanador.salud} puntos de salud.");
        }


    }
}
