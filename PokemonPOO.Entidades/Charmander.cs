namespace PokemonPOO.Entidades
{
    public class Charmander : Pokemon
    {
        public string nivelDeLlama { get; set; }
        public override void evolucionar()
        {
            if (this.nivel < 16)
            {
                Console.WriteLine("${this.nombre} todavia no está listo para evolucionar, necesita subir ${16-this.nivel} niveles más");
            }
            else if (this.nivel >= 16)
            {
                Console.WriteLine("${this.nombre} está listo!");
                Console.WriteLine("${this.nombre} está evolucionando a ${this.evoluciones[0]}");
            }
            else if (this.nivel >= 36)
            {
                Console.WriteLine("${this.nombre} está listo!");
                Console.WriteLine("${this.nombre} está evolucionando a ${this.evoluciones[1]}");
            }
        }

        public override string ToString()
        {
            return $"Soy un pokemon {nombre}, mi id es #{idPokemon} soy de tipo {tipoPrincipal.nombreTipo}, y mi llama está {nivelDeLlama}. Me encantaria llegar a evolucionar a {evoluciones[1]}";
        }

    }
}
