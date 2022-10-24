using PokemonPOO.Entidades;

namespace PokemonPOO.Datastore
{
    public class DataStorage
    {
        private Tipo tipoPlanta = new Tipo(3, "planta");
        private Tipo tipoAgua = new Tipo(2, "agua");
        private Tipo tipoFuego = new Tipo(1, "fuego");
        private Tipo tipoVeneno = new Tipo(8, "veneno");
        private Tipo tipoElectrico = new Tipo(5, "electrico");

        private Bulbasaur crearBulbasaur() {
            //----Creamos los cuatro pokemones----

            //Creando a bulbasaur
            Bulbasaur bulbasaur = new Bulbasaur()
            {
                idPokemon = 1,
                nombre = "bulbasaur",
                tipoPrincipal = tipoPlanta,
                tipoSecundario = tipoVeneno,
                salud = 318,
                capacidadAtaque = 49,
                capacidadDefensa = 49,
                peso = 6.9,
                altura = 0.7,
                nivel = 5,
                evoluciones = new List<string>() {
                                                "ivysaur", "venasaur"
                                            },
                descripcion = "A Bulbasaur es fácil verle echándose una siesta al sol. " +
                                                                   "La semilla que tiene en el lomo va creciendo cada vez más a medida que absorbe " +
                                                                   "los rayos del sol.",
                tamanioSemilla = 2
            };

            return bulbasaur;
        }
        private Charmander crearCharmander() {
            //Creando a charmander
            Charmander charmander = new Charmander()
            {
                idPokemon = 4,
                nombre = "charmander",
                tipoPrincipal = tipoFuego,
                salud = 309,
                capacidadAtaque = 52,
                capacidadDefensa = 43,
                peso = 8.5,
                altura = 0.6,
                nivel = 10,
                evoluciones = new List<string>() {
                                                    "charmeleon", "charizard"
                                                    },
                descripcion = "La llama que tiene en la punta de la cola arde según sus sentimientos. " +
                                                        "Llamea levemente cuando está alegre y arde vigorosamente cuando está enfadado.",
                nivelDeLlama = "normal"
            };

            return charmander;
        }
        private Pikachu crearPikachu() {

            //Creando a pikachu
            Pikachu pikachu = new Pikachu()
            {
                idPokemon = 25,
                nombre = "pikachu",
                tipoPrincipal = tipoElectrico,
                salud = 320,
                capacidadAtaque = 55,
                capacidadDefensa = 40,
                peso = 6.0,
                altura = 0.4,
                nivel = 20,
                evoluciones = new List<string>() {
                                                        "raichu"
                                                        },
                descripcion = "Cada vez que un Pikachu se encuentra con algo nuevo, le lanza una descarga eléctrica. Cuando " +
                                                              "se ve alguna baya chamuscada, es muy probable que sea obra de un Pikachu, ya que a veces no controlan la intensidad de la descarga.",
                nivelDeEstabilidad = "alta"
            };

            return pikachu;
        }
        private Squirtle crearSquirtle() {
            //Creando a squirtle
            Squirtle squirtle = new Squirtle()
            {
                idPokemon = 7,
                nombre = "squirtle",
                tipoPrincipal = tipoAgua,
                salud = 314,
                capacidadAtaque = 48,
                capacidadDefensa = 65,
                peso = 9.0,
                altura = 0.5,
                nivel = 8,
                evoluciones = new List<string>() {
                                                     "wartortle","blastoise"
                                                     },
                descripcion = "\tEl caparazón de Squirtle no le sirve de protección únicamente. Su forma " +
                                                          "redondeada y las hendiduras que tiene le ayudan a deslizarse en el agua y le permiten nadar a gran velocidad.",
                durezaCaparazon = "media"
            };

            return squirtle;
        }

        public List<Tipo> GetTipos() {
            List<Tipo> aTipos = new List<Tipo> {
                                        tipoPlanta,
                                        tipoAgua,
                                        tipoFuego,
                                        tipoVeneno,
                                        tipoElectrico,
                                        };

            return aTipos;
        }

        public List<Pokemon> GetPokemones() {

            return new List<Pokemon>{
                                      crearBulbasaur(),
                                      crearCharmander(),
                                      crearPikachu(),
                                      crearSquirtle()

                                       };

        }

        private List<Pokedex> GetPokedexs() {
            Pokedex pokedexSonia = new Pokedex()
            {
                idPokedex = 4,
                pokemonesRegistrados = new List<Pokemon>() {
                                                             crearCharmander(),
                                                             crearSquirtle()
                                                            }
            };
            Pokedex pokedexAsh = new Pokedex()
            {
                idPokedex = 6,
                pokemonesRegistrados = new List<Pokemon>()
            };

            return new List<Pokedex> { pokedexAsh, pokedexSonia };
        }

        public List<EntrenadorPokemon> GetEntrenadoresPokemon(){

            List<Pokedex> aPokedexs = GetPokedexs();

            EntrenadorPokemon ash = new EntrenadorPokemon()
            {
                idEntrenador = 24,
                nombre = "Ash",
                apellido = "Ketchup",
                pokedex = aPokedexs[0],
                aPokemones = new List<Pokemon>() {
                                                    crearPikachu(),
                                                    crearBulbasaur()
                                                  }
            };

            EntrenadorPokemon sonia = new EntrenadorPokemon()
            {
                idEntrenador = 15,
                nombre = "Sonia",
                apellido = "Daysutke",
                pokedex = aPokedexs[1],
                aPokemones = new List<Pokemon>() {
                                                   crearCharmander(),
                                                   crearSquirtle()
                                                  }
            };

            return new List<EntrenadorPokemon>{ ash,sonia };

        }

        public List<CampoDeBatalla> GetCamposDeBatalla() {

            CampoDeBatalla campoDeBatalla = new CampoDeBatalla()
            {
                idCampoDeBatalla = 45,
                nombre = "Liga naranja",
                localizacion = "Meseta Añil",
                pokemones = new List<Pokemon>() {
                                                  crearPikachu(),
                                                  crearSquirtle()
                                                }
            };

            return new List<CampoDeBatalla> { campoDeBatalla };
        }
    }
}