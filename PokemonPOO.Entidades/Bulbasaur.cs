namespace PokemonPOO.Entidades
{
    public class Bulbasaur : Pokemon
    {
        public int tamanioSemilla { get; set; }
        public override void evolucionar()
        {
            if (this.nivel < 16)
            {
                Console.WriteLine($"{this.nombre} todavia no está listo para evolucionar, necesita subir {16 - this.nivel} niveles más");
            }
            else if (this.nivel >= 16)
            {
                Console.WriteLine($"{this.nombre} está listo!");
                Console.WriteLine($"{this.nombre} está evolucionando a {this.evoluciones[0]}");
            }
            else if (this.nivel >= 32)
            {
                Console.WriteLine($"{this.nombre} está listo!");
                Console.WriteLine($"{this.nombre} está evolucionando a {this.evoluciones[1]}");
            }
        }
        public override string ToString()
        {
            return $"Soy un pokemon {nombre}, mi id es #{idPokemon} soy de tipo {tipoPrincipal.nombreTipo} y {tipoSecundario!.nombreTipo}, mis evoluciones son {evoluciones[0]} y {evoluciones[1]} y mi semilla es de tamaño {tamanioSemilla}";
        }


    }
;
}

