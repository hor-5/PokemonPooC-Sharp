// See https://aka.ms/new-console-template for more information


using PokemonPOO.Entidades;


    //creamos los tipos de pokemon
    Tipo tipoPlanta = new Tipo(3,"planta");
    Tipo tipoAgua = new Tipo(2, "agua" );
    Tipo tipoFuego = new Tipo(1, "fuego");
    Tipo tipoVeneno= new Tipo(8, "veneno");
    Tipo tipoElectrico =  new Tipo(5, "electrico");

    //método para pausar la ejecución
    static void pausarEjecucion(int milisegundos) {
        Thread.Sleep(milisegundos);
    }
    //método para seleccionar pokemones para la batalla
    static List<Pokemon> seleccionarPokemonesParaBatalla(EntrenadorPokemon entrenador1, EntrenadorPokemon entrenador2) {
        List<EntrenadorPokemon> iterableEntrenadores = new List<EntrenadorPokemon> { entrenador1, entrenador2 };
        List<Pokemon> pokemonesABatallar = new List<Pokemon>();

        foreach (EntrenadorPokemon entrenador in iterableEntrenadores) {
            string pokemonIngresado;            
            Console.WriteLine($"\nSelecciona el pokemon de {entrenador.nombre} para la batalla...");
            entrenador.verPokemones();
            pokemonIngresado = Console.ReadLine();
            Pokemon resultado = entrenador.elegirPokemon(pokemonIngresado.ToLower());
            while (resultado == null)
            {
                Console.WriteLine("\nIngrese un pokemon válido");
                pokemonIngresado = Console.ReadLine();
                resultado = entrenador.elegirPokemon(pokemonIngresado.ToLower());
                
            }
            pokemonesABatallar.Add(resultado);
            Console.WriteLine($"\n{entrenador.nombre} {entrenador.apellido} seleccionó a {pokemonIngresado.ToLower()}");            
        }

    return pokemonesABatallar;
}
    

//----Creamos los cuatro pokemones----

//Creando a bulbasaur
Bulbasaur bulbasaur = new Bulbasaur() {
                                        idPokemon=1,
                                        nombre="bulbasaur",
                                        tipoPrincipal = tipoPlanta,
                                        tipoSecundario = tipoVeneno,
                                        salud = 318,
                                        capacidadAtaque= 49,
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

//Creando a charmander
Charmander charmander = new Charmander(){
                                          idPokemon=4,
                                          nombre="charmander",
                                          tipoPrincipal = tipoFuego,
                                          salud=309,
                                          capacidadAtaque=52,
                                          capacidadDefensa=43,
                                          peso=8.5,
                                          altura=0.6,
                                          nivel=10,
                                          evoluciones= new List<string>() {
                                                    "charmeleon", "charizard"
                                                    },
                                          descripcion= "La llama que tiene en la punta de la cola arde según sus sentimientos. " +
                                            "Llamea levemente cuando está alegre y arde vigorosamente cuando está enfadado.",
                                          nivelDeLlama="normal"
                                           };

//Creando a pikachu
Pikachu pikachu = new Pikachu(){
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

//Creando a squirtle
Squirtle squirtle = new Squirtle(){
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
                                durezaCaparazon="media"
                            };
//Creando pokedex
Pokedex pokedexSonia = new Pokedex() {
                                        idPokedex=4,
                                        pokemonesRegistrados= new List<Pokemon>() {
                                                                                    charmander,squirtle
                                                                                    }
                                        };
Pokedex pokedexAsh = new Pokedex() {
                                    idPokedex = 6,
                                    pokemonesRegistrados = new List<Pokemon>()
                                    };

//creamos un entrenador pokemon

EntrenadorPokemon ash = new EntrenadorPokemon(){
                                                idEntrenador=24,
                                                nombre="Ash",
                                                apellido="Ketchup",
                                                pokedex = pokedexAsh,
                                                aPokemones=new List<Pokemon>() {bulbasaur}
                                                };

EntrenadorPokemon sonia = new EntrenadorPokemon(){
                                                  idEntrenador = 15,
                                                  nombre = "Sonia",
                                                  apellido = "Daysutke",
                                                  pokedex = pokedexSonia,
                                                  aPokemones = new List<Pokemon>() {
                                                                                    charmander,squirtle
                                                                                    }
                                                  };

//empieza el programa
Console.WriteLine("                                  ,'\\\n" +
        "    _.----.        ____         ,'  _\\   ___    ___     ____\n" +
        "_,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.\n" +
        "\\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |\n" +
        " \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |\n" +
        "   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |\n" +
        "    \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |\n" +
        "     \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |\n" +
        "      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |\n" +
        "       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |\n" +
        "        \\_.-'       |__|    `-._ |              '-.|     '-.| |   |\n" +
        "                                `'                            '-._|\n");

//Saludo bienvenida.
Console.WriteLine("Bienvenido al mundo pokemon!");
pausarEjecucion(1000);
Console.WriteLine("Vamos a ver nuestros pokemones...\n");
pausarEjecucion(2000);
//usando metodos toString de cada pokemon
Console.WriteLine(squirtle);
pausarEjecucion(2000);
Console.WriteLine(pikachu);
pausarEjecucion(2000);
Console.WriteLine(charmander);
pausarEjecucion(2000);
Console.WriteLine(bulbasaur);
pausarEjecucion(2000);

//El entrenador Ash atrapó a Pikachu
Console.WriteLine("\nAsh atrapó a pikachu\n");
ash.aPokemones.Add(pikachu);
pausarEjecucion(2000);

////metodos de entrenamiento sobrecarga
ash.entrenarPokemon("pikachu");
pausarEjecucion(2000);
ash.entrenarPokemon(pikachu, 3);
pausarEjecucion(2000);
sonia.entrenarPokemon(charmander);
pausarEjecucion(2000);

//sonia encuentra a ash con pikachu y consulta su pokedex
Console.WriteLine("Sonia encuentra a ash con pikachu y consulta su pokedex");
sonia.pokedex.registrarPokemon(pikachu);
pausarEjecucion(5000);

//ash encuentra a Sonia con Charmander y consulta su pokedex
Console.WriteLine("Ash encuentra a Sonia con Charmander y consulta su pokedex");
ash.pokedex.registrarPokemon(charmander);
pausarEjecucion(5000);

//Estableciendo campo de batalla
CampoDeBatalla campoDeBatalla = new CampoDeBatalla()
{
    idCampoDeBatalla = 45,
    nombre = "Liga naranja",
    localizacion = "Meseta Añil",

};

//Campo de batalla bienvenida
Console.WriteLine($"\nBienvenido al campo de batalla de {campoDeBatalla.nombre}");
pausarEjecucion(2000);
Console.WriteLine("\npresiona ENTER para continuar");
Console.ReadLine();

//SeleccionarPokemones para batalla
List<Pokemon> pokemonesParaBatalla = seleccionarPokemonesParaBatalla(ash,sonia);

campoDeBatalla.pokemones = pokemonesParaBatalla;

//
pausarEjecucion(2000);
Console.WriteLine("\npresiona ENTER para comenzar la batalla");
Console.ReadLine();
campoDeBatalla.comenzarBatalla();