namespace PokemonPOO.Entidades
{
    public abstract class Pokemon
    {
        public int idPokemon { get; set; }
        public string nombre { get; set; }
        public Tipo tipoPrincipal { get; set; }
        public Tipo? tipoSecundario { get; set; }
        public int salud { get; set; }
        public int capacidadAtaque { get; set; }
        public int capacidadDefensa { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public int nivel { get; set; }
        public List<string> evoluciones { get; set; }
        public string descripcion { get; set; }        
        public string imgUrl { get; set; }

        public virtual void getEvoluciones()
        {
            Console.WriteLine($"las evoluciones de {nombre} son:");
            foreach (string evolucion in evoluciones)
            {
                Console.WriteLine(evolucion);
            }
        }

        public void atacar(Pokemon pokemon)
        {
            if (pokemon.salud > 0 && this.salud > 0)
            {
                if (this.tipoPrincipal.esEfectivoContra(pokemon.tipoPrincipal.nombreTipo))
                {
                    Console.WriteLine($"\nLos pokemon de tipo {this.tipoPrincipal.nombreTipo.ToUpper()} como {this.nombre} son efectivos contra los de tipo {pokemon.tipoPrincipal.nombreTipo.ToUpper()}");
                    Console.WriteLine($"{this.nombre.ToUpper()} le infringe el doble de daño a {pokemon.nombre.ToUpper()}");
                    Console.WriteLine($"\n{this.nombre} tiene {this.salud} de salud y está atacando...");
                    pokemon.salud -= (this.capacidadAtaque * 2);
                }
                else
                {
                    Console.WriteLine($"\n{this.nombre} tiene {this.salud} de salud y está atacando...");
                    pokemon.salud -= this.capacidadAtaque;
                }

            }
            else
            {
                if (pokemon.salud <= 0)
                {
                    Console.WriteLine($"\nEl pokemon {pokemon.nombre.ToUpper()} ha sido derrotado por {this.nombre.ToUpper()}");
                }
                else if (this.salud <= 0)
                {
                    Console.WriteLine($"El pokemon {this.nombre.ToUpper()} ha sido derrotado por {pokemon.nombre.ToUpper()}");
                }

            }
        }

        public void defenderse()
        {
            if (this.salud > 0)
            {
                Console.WriteLine($"\n{this.nombre} se está defendiendo y recuperando salud, ahora tiene {this.salud} de salud");
                this.salud += this.capacidadDefensa;
            }
            else
            {
                Console.WriteLine($"{this.nombre} ha sido derrotado...");
            }
        }

        public void entrenar()
        {
            Console.WriteLine($"\n{this.nombre} nivel {this.nivel} está entrenando... ");
            this.nivel++;
            Console.WriteLine($"{this.nombre} subió un nivel, ahora es nivel {this.nivel}.\n");
        }

        public void entrenar(int intensidad)
        {
            Console.WriteLine($"\n{this.nombre} nivel {this.nivel} está entrenando intensamente... ");
            this.nivel += intensidad;
            Console.WriteLine($"{this.nombre} subió {intensidad} niveles, ahora es nivel {this.nivel}.\n");
        }

        public abstract void evolucionar();


    }


}