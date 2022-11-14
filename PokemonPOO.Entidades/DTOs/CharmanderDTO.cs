using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPOO.Entidades.DTOs
{
    public class CharmanderDTO
    {
        public int idPokemon { get; set; }
        public string nombre { get; set; }
        public int idTipoPrincipal { get; set; }
        public string tipoPrincipal { get; set; }
        public int salud { get; set; }
        public int capacidadAtaque { get; set; }
        public int capacidadDefensa { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public int nivel { get; set; }
        public string descripcion { get; set; }
        public string imgUrl { get; set; }
        public string nivelDeLlama { get; set; }
    }
}
