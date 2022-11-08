namespace PokemonPOO.Entidades
{
    public class Pikachu : Pokemon
    {
        public string nivelDeEstabilidad { get; set; }

        public override void getEvoluciones()
        {
            Console.WriteLine($"la unica evolucion para $nombre es {this.evoluciones[0]}");
        }
        public override void evolucionar()
        {
            if (this.nivel < 30)
            {
                Console.WriteLine($"{this.nombre} todavia no está listo para evolucionar, necesita subir {30 - this.nivel} niveles más");
            }
            else if (this.nivel >= 30)
            {
                Console.WriteLine($"{this.nombre} está listo!");
                Console.WriteLine($"{this.nombre} está evolucionando a {this.evoluciones[0]}");
            }
        }

        public override string ToString()
        {
            return $"Soy un pokemon {nombre}, mi id es #{idPokemon} soy de tipo {tipoPrincipal.nombreTipo}, y mi estabilidad ahora es {nivelDeEstabilidad}";
        }

    }
}
