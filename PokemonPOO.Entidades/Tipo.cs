namespace PokemonPOO.Entidades
{
    public class Tipo
    {
        public int idTipo { get; set; }
        public string nombreTipo { get; set; }
        //establecemos la efectividad contra x tipos de pokemon según el tipo de pokemon invocando al metodo set
        public List<string> efectividad;

        //establecemos las debilidad contra X tipos de pokemon según el tipo de pokemon llamando al metodo set
        public List<string> debilidad;

        public Tipo(int id, string nombre)
        {
            this.idTipo = id;
            this.nombreTipo = nombre;
            this.efectividad = setEfectividad();
            this.debilidad = setDebilidad();
        }
        public List<string> setEfectividad()
        {
            List<string> listaEfectividad = null;

            switch (nombreTipo)
            {
                case "agua":
                    listaEfectividad = new List<string>() {
                        "tierra","fuego","roca"
                    };
                    break;
                case "fuego":
                    listaEfectividad = new List<string>() {
                        "bicho","planta","acero","hielo"
                    };
                    break;
                case "planta":
                    listaEfectividad = new List<string>() {
                        "tierra","roca","agua"
                    };
                    break;
                case "electrico":
                    listaEfectividad = new List<string>() {
                        "volador","agua"
                    };
                    break;
                case "veneno":
                    listaEfectividad = new List<string>() {
                        "planta","hada"
                    };
                    break;
                default:
                    listaEfectividad = new List<string>();
                    break;
            }

            return listaEfectividad;
        }

        public List<string> setDebilidad()
        {
            List<string> listaDebilidad = null;

            switch (nombreTipo)
            {
                case "agua":
                    listaDebilidad = new List<string>() {
                        "electrico","planta"
                    };
                    break;
                case "fuego":
                    listaDebilidad = new List<string>() {
                        "agua","roca","tierra"
                    };
                    break;
                case "planta":
                    listaDebilidad = new List<string>() {
                        "bicho","fuego","volador","veneno","hielo"
                    };
                    break;
                case "electrico":
                    listaDebilidad = new List<string>() {
                        "tierra"
                    };
                    break;
                case "veneno":
                    listaDebilidad = new List<string>() {
                        "psiquico","tierra"
                    };
                    break;
                default:
                    listaDebilidad = new List<string>();
                    break;
            }

            return listaDebilidad;
        }

        public bool esEfectivoContra(string nombreTipo)
        {
            return efectividad.Contains(nombreTipo);
        }

        public bool esDebilContra(string nombreTipo)
        {
            return debilidad.Contains(nombreTipo);
        }

    }
}
