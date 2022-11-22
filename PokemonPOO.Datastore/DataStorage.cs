using PokemonPOO.Entidades;
using PokemonPOO.Entidades.DTOs;

namespace PokemonPOO.Datastore
{
    public class DataStorage
    {
        DBOperation dbOperation = new DBOperation();

        //Bulbasaur métodos
        private List<string> getEvolucionesBulbasaur(int idBulbasaur) {
            List<String> LstEvoluciones = new List<String>();
            string sql = "SELECT DISTINCT E.nombreEvolucion FROM Evoluciones E INNER JOIN" +
                         " Pokemones P ON E.fk_idPokemon = " + idBulbasaur;
            LstEvoluciones = dbOperation.OperationQuery<String>(sql);
            return LstEvoluciones;
        }
        private Bulbasaur parseBulbasaurDTO(BulbasaurDTO bulbasaurDTO) {
            return new Bulbasaur()
            {
                idPokemon = bulbasaurDTO.idPokemon,
                nombre = bulbasaurDTO.nombre,
                tipoPrincipal = new Tipo(bulbasaurDTO.idTipoPrincipal, bulbasaurDTO.tipoPrincipal),
                tipoSecundario = new Tipo(bulbasaurDTO.idTipoSecundario, bulbasaurDTO.tipoSecundario),
                salud = bulbasaurDTO.salud,
                capacidadAtaque = bulbasaurDTO.capacidadAtaque,
                capacidadDefensa = bulbasaurDTO.capacidadDefensa,
                peso = bulbasaurDTO.peso,
                altura = bulbasaurDTO.altura,
                nivel = bulbasaurDTO.nivel,
                evoluciones = getEvolucionesBulbasaur(bulbasaurDTO.idPokemon),
                descripcion = bulbasaurDTO.descripcion,
                imgUrl = bulbasaurDTO.imgUrl
            };
        }
        private Bulbasaur getBulbasaur() {
            List<BulbasaurDTO> LstBulbasaurDTO = new List<BulbasaurDTO>();
            string sql = "SELECT P.idPokemon, P.nombre,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal," +
                            "TI.idTipo as idTipoSecundario,TI.nombreTipo as tipoSecundario,P.salud,P.capacidadAtaque," +
                            "P.capacidadDefensa, P.peso,P.altura,P.nivel,P.descripcion, P.imgUrl, P.tamanioSemilla" +
                            " FROM Pokemones P" +
                            " INNER JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                            " INNER JOIN Tipos TI ON P.fk_idTipoSecundario = TI.idTipo" +
                            " WHERE P.nombre = 'bulbasaur' ";
            LstBulbasaurDTO = dbOperation.OperationQuery<BulbasaurDTO>(sql);

            Bulbasaur bulbasaur = parseBulbasaurDTO(LstBulbasaurDTO.First());

            return bulbasaur;
        }
        
        //Charmander métodos
        private List<string> getEvolucionesCharmander(int idCharmander) {
            List<String> LstEvoluciones = new List<String>();
            string sql = "SELECT DISTINCT E.nombreEvolucion FROM Evoluciones E INNER JOIN" +
                         " Pokemones P ON E.fk_idPokemon = " + idCharmander;
            LstEvoluciones = dbOperation.OperationQuery<String>(sql);

            return LstEvoluciones;
        }
        private Charmander parseCharmanderDTO(CharmanderDTO charmanderDTO) {
            return new Charmander()
            {
                idPokemon = charmanderDTO.idPokemon,
                nombre = charmanderDTO.nombre,
                tipoPrincipal = new Tipo(charmanderDTO.idTipoPrincipal, charmanderDTO.tipoPrincipal),
                salud = charmanderDTO.salud,
                capacidadAtaque = charmanderDTO.capacidadAtaque,
                capacidadDefensa = charmanderDTO.capacidadDefensa,
                peso = charmanderDTO.peso,
                altura = charmanderDTO.altura,
                nivel = charmanderDTO.nivel,
                evoluciones = getEvolucionesCharmander(charmanderDTO.idPokemon),
                descripcion = charmanderDTO.descripcion,
                imgUrl = charmanderDTO.imgUrl
            };
        }
        private Charmander getCharmander()
        {
            List<CharmanderDTO> LstCharmanderDTO = new List<CharmanderDTO>();
            string sql = "SELECT P.idPokemon, P.nombre,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal," +
                        "P.salud,P.capacidadAtaque,P.capacidadDefensa, P.peso,P.altura,P.nivel,P.descripcion," +
                        "P.imgUrl, P.nivelDeLlama" +
                        " FROM Pokemones P" +
                        " INNER JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                        " WHERE P.nombre = 'charmander' ";
            LstCharmanderDTO = dbOperation.OperationQuery<CharmanderDTO>(sql);

            Charmander charmander = parseCharmanderDTO(LstCharmanderDTO.First());

            return charmander;
        }

        //Pikachu métodos
        private List<string> getEvolucionesPikachu(int idPikachu) {
            List<String> LstEvoluciones = new List<String>();
            string sql = "SELECT DISTINCT E.nombreEvolucion FROM Evoluciones E INNER JOIN" +
                " Pokemones P ON E.fk_idPokemon = " + idPikachu;
            LstEvoluciones = dbOperation.OperationQuery<String>(sql);

            return LstEvoluciones;
        }
        private Pikachu parsePikachuDTO(PikachuDTO pikachuDTO) { 
            return new Pikachu()
            {
                idPokemon = pikachuDTO.idPokemon,
                nombre = pikachuDTO.nombre,
                tipoPrincipal = new Tipo(pikachuDTO.idTipoPrincipal, pikachuDTO.tipoPrincipal),
                salud = pikachuDTO.salud,
                capacidadAtaque = pikachuDTO.capacidadAtaque,
                capacidadDefensa = pikachuDTO.capacidadDefensa,
                peso = pikachuDTO.peso,
                altura = pikachuDTO.altura,
                nivel = pikachuDTO.nivel,
                evoluciones = getEvolucionesPikachu(pikachuDTO.idPokemon),
                descripcion = pikachuDTO.descripcion,
                imgUrl = pikachuDTO.imgUrl
            };
        }
        private Pikachu getPikachu() {
            List<PikachuDTO> LstPikachuDTO = new List<PikachuDTO>();
            string sql = "SELECT P.idPokemon, P.nombre,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal," +
                        "P.salud,P.capacidadAtaque,P.capacidadDefensa, P.peso,P.altura,P.nivel,P.descripcion," +
                        "P.imgUrl, P.nivelDeEstabilidad" +
                        " FROM Pokemones P" +
                        " INNER JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                        " WHERE P.nombre = 'pikachu' ";
            LstPikachuDTO = dbOperation.OperationQuery<PikachuDTO>(sql);
            
            Pikachu pikachu = parsePikachuDTO(LstPikachuDTO.First());
                        
            return pikachu;
        }

        //Squirtle métodos
        private List<string> getEvolucionesSquirtle(int idSquirtle) {
            List<String> LstEvoluciones = new List<String>();
            string sql = "SELECT DISTINCT E.nombreEvolucion FROM Evoluciones E INNER JOIN Pokemones P ON E.fk_idPokemon = " + idSquirtle;
            LstEvoluciones = dbOperation.OperationQuery<String>(sql);
            return LstEvoluciones;
        }
        private Squirtle parseSquirtleDTO(SquirtleDTO squirtleDTO)
        {            
            return new Squirtle()
            {
                idPokemon = squirtleDTO.idPokemon,
                nombre = squirtleDTO.nombre,
                tipoPrincipal = new Tipo(squirtleDTO.idTipoPrincipal, squirtleDTO.tipoPrincipal),
                salud = squirtleDTO.salud,
                capacidadAtaque = squirtleDTO.capacidadAtaque,
                capacidadDefensa = squirtleDTO.capacidadDefensa,
                peso = squirtleDTO.peso,
                altura = squirtleDTO.altura,
                nivel = squirtleDTO.nivel,
                evoluciones = getEvolucionesSquirtle(squirtleDTO.idPokemon),
                descripcion = squirtleDTO.descripcion,
                imgUrl = squirtleDTO.imgUrl
            };
        }
        private Squirtle getSquirtle()
        {
            List<SquirtleDTO> LstSquirtleDTO = new List<SquirtleDTO>();
            string sql = "SELECT P.idPokemon, P.nombre,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal," +
                        "P.salud,P.capacidadAtaque,P.capacidadDefensa, P.peso,P.altura,P.nivel,P.descripcion," +
                        "P.imgUrl, P.durezaCaparazon" +
                        " FROM Pokemones P" +
                        " INNER JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                        " WHERE P.nombre = 'squirtle' ";
            LstSquirtleDTO = dbOperation.OperationQuery<SquirtleDTO>(sql);

            Squirtle squirtle = parseSquirtleDTO( LstSquirtleDTO.First() );

            return squirtle;
        }
    

        //Tipos
        public List<Tipo> GetTipos()
        {
            List<TipoDTO> LstTiposDTO = new List<TipoDTO>();
            string sql = "SELECT T.idTipo,T.nombreTipo FROM Tipos T "+
                          "WHERE T.nombreTipo = 'agua' OR T.nombreTipo = 'fuego' OR T.nombreTipo = 'electrico' "+
                          "OR T.nombreTipo = 'planta' OR T.nombreTipo = 'veneno' ";
            LstTiposDTO = dbOperation.OperationQuery<TipoDTO>(sql);

            List<Tipo> aTipos = new List<Tipo> {
                                        new Tipo(LstTiposDTO[0].idTipo,LstTiposDTO[0].nombreTipo),
                                        new Tipo(LstTiposDTO[1].idTipo,LstTiposDTO[1].nombreTipo),
                                        new Tipo(LstTiposDTO[2].idTipo,LstTiposDTO[2].nombreTipo),
                                        new Tipo(LstTiposDTO[3].idTipo,LstTiposDTO[3].nombreTipo),
                                        new Tipo(LstTiposDTO[4].idTipo,LstTiposDTO[4].nombreTipo),
                                        };

            return aTipos;
        }

        //Pokemones
        public List<Pokemon> GetPokemones()
        {
            
            return new List<Pokemon>{
                                      getBulbasaur(),
                                      getCharmander(),
                                      getPikachu(),
                                      getSquirtle()
                                       };

        }

        public List<Pokemon> GetPokemonesEntrenador(int idEntrenador) {

            List<Pokemon> pokemones = new List<Pokemon>();
            //----------------//
            List<SquirtleDTO> lstSquirtles = new List<SquirtleDTO>();
            string sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal" +
                         " FROM Entrenadores E INNER JOIN Pokemones P ON E.idEntrenador= P.fk_idEntrenador" +
                         " LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                         " WHERE P.nombre = 'squirtle' AND E.idEntrenador =" + idEntrenador;
            lstSquirtles = dbOperation.OperationQuery<SquirtleDTO>(sql);
            if (lstSquirtles.Any())
            {

                Squirtle squirtle = parseSquirtleDTO(lstSquirtles.First());

                pokemones.Add(squirtle);
            }
            //-----------------//
            List<CharmanderDTO> lstCharmanders = new List<CharmanderDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal" +
                  " FROM Entrenadores E INNER JOIN Pokemones P ON E.idEntrenador= P.fk_idEntrenador" +
                  " LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                  " WHERE P.nombre = 'charmander' AND E.idEntrenador =" + idEntrenador;
            lstCharmanders = dbOperation.OperationQuery<CharmanderDTO>(sql);
            if (lstCharmanders.Any())
            {
                Charmander charmander = parseCharmanderDTO(lstCharmanders.First());

                pokemones.Add(charmander);
            }
            //-----------------//
            List<PikachuDTO> lstPikachus = new List<PikachuDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal" +
                " FROM Entrenadores E INNER JOIN Pokemones P ON E.idEntrenador= P.fk_idEntrenador" +
                " LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                " WHERE P.nombre = 'pikachu' AND E.idEntrenador ="+ idEntrenador;
            lstPikachus = dbOperation.OperationQuery<PikachuDTO>(sql);
            if (lstPikachus.Any())
            {
                Pikachu pikachu = parsePikachuDTO(lstPikachus.First());

                pokemones.Add(pikachu);
            }
            //-----------------//
            List<BulbasaurDTO> lstBulbasaurs = new List<BulbasaurDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal,TI.idTipo as idTipoSecundario,TI.nombreTipo as tipoSecundario" +
                " FROM Entrenadores E INNER JOIN Pokemones P ON E.idEntrenador= P.fk_idEntrenador" +
                " LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo" +
                " LEFT JOIN Tipos TI ON P.fk_idTipoSecundario = TI.idTipo" +
                " WHERE P.nombre = 'bulbasaur' AND E.idEntrenador = "+idEntrenador;
            lstBulbasaurs = dbOperation.OperationQuery<BulbasaurDTO>(sql);
            if (lstBulbasaurs.Any())
            {
                Bulbasaur bulbasaur = parseBulbasaurDTO(lstBulbasaurs.First());

                pokemones.Add(bulbasaur);
            }
            //-----------------//
            return pokemones;
        }

        public int SubirNivelPokemon(int idPokemon, int nivel)
        {
            string sql = "UPDATE Pokemones SET nivel = @nivel WHERE idPokemon = @idPokemon";
            Object paramList = new { idPokemon = idPokemon, nivel = nivel };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;
        }

        //Pokedexs
        private List<Pokedex> GetPokedexs()
        {
            List<Pokedex> pokedexs = new List<Pokedex>();

            string sql = "SELECT idPokedex FROM Pokedex";
            pokedexs = dbOperation.OperationQuery<Pokedex>(sql);
            pokedexs[0].pokemonesRegistrados = new List<Pokemon>() {getPikachu() };
            pokedexs[1].pokemonesRegistrados = new List<Pokemon>() { getCharmander(), getSquirtle() };

            return pokedexs;
        }

        //Entrenadores
        public List<EntrenadorPokemon> GetEntrenadoresPokemon()
        {

            List<Pokedex> aPokedexs = GetPokedexs();

            List<EntrenadorPokemon> LstEntrenadores = new List<EntrenadorPokemon>();
            string sql = "SELECT idEntrenador,nombre,apellido, imgUrl FROM Entrenadores";
            LstEntrenadores = dbOperation.OperationQuery<EntrenadorPokemon>(sql);

            for (var i = 0; i < LstEntrenadores.Count(); i++)
            {
                LstEntrenadores[i].pokedex = aPokedexs[i];
                LstEntrenadores[i].aPokemones = GetPokemonesEntrenador(LstEntrenadores[i].idEntrenador);
            }

            return LstEntrenadores;            

        }

        //Campos de batalla
        public List<CampoDeBatalla> GetCamposDeBatalla()
        {

            List<CampoDeBatalla> camposDeBatalla = new List<CampoDeBatalla>();
            string sql = "SELECT idCampoDeBatalla, nombre,localizacion FROM CamposDeBatalla";
            camposDeBatalla = dbOperation.OperationQuery<CampoDeBatalla>(sql);

            camposDeBatalla.First().pokemones = new List<Pokemon>();

            //----------------//
            List<SquirtleDTO> lstSquirtles = new List<SquirtleDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal " +
                "FROM CamposDeBatalla C INNER JOIN Pokemones P ON C.idCampoDeBatalla= P.fk_idCampoBatalla " +
                "LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo WHERE P.nombre = 'squirtle'";
            lstSquirtles = dbOperation.OperationQuery<SquirtleDTO>(sql);
            if (lstSquirtles.Any()) {

                Squirtle squirtle = parseSquirtleDTO(lstSquirtles.First());

                camposDeBatalla.First().pokemones.Add(squirtle);
            }
            //-----------------//
            List<CharmanderDTO> lstCharmanders = new List<CharmanderDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal " +
                "FROM CamposDeBatalla C INNER JOIN Pokemones P ON C.idCampoDeBatalla= P.fk_idCampoBatalla " +
                "LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo WHERE P.nombre = 'charmander'";
            lstCharmanders = dbOperation.OperationQuery<CharmanderDTO>(sql);
            if (lstCharmanders.Any())
            {
                Charmander charmander = parseCharmanderDTO(lstCharmanders.First());

                camposDeBatalla.First().pokemones.Add(charmander);
            }
            //-----------------//
            List<PikachuDTO> lstPikachus = new List<PikachuDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal " +
                "FROM CamposDeBatalla C INNER JOIN Pokemones P ON C.idCampoDeBatalla= P.fk_idCampoBatalla " +
                "LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo WHERE P.nombre = 'pikachu'";
            lstPikachus = dbOperation.OperationQuery<PikachuDTO>(sql);
            if (lstPikachus.Any())
            {
                Pikachu pikachu = parsePikachuDTO(lstPikachus.First());

                camposDeBatalla.First().pokemones.Add(pikachu);
            }
            //-----------------//
            List<BulbasaurDTO> lstBulbasaurs = new List<BulbasaurDTO>();
            sql = "SELECT P.*,T.idTipo as idTipoPrincipal, T.nombreTipo as tipoPrincipal,TI.idTipo as idTipoSecundario,TI.nombreTipo as tipoSecundario " +
                "FROM CamposDeBatalla C INNER JOIN Pokemones P ON C.idCampoDeBatalla= P.fk_idCampoBatalla " +
                "LEFT JOIN Tipos T ON P.fk_idTipoPrincipal = T.idTipo " +
                "LEFT JOIN Tipos TI ON P.fk_idTipoSecundario = TI.idTipo WHERE P.nombre = 'bulbasaur'";
            lstBulbasaurs = dbOperation.OperationQuery<BulbasaurDTO>(sql);
            if (lstBulbasaurs.Any())
            {
                Bulbasaur bulbasaur = parseBulbasaurDTO(lstBulbasaurs.First());

                camposDeBatalla.First().pokemones.Add(bulbasaur);
            }
            //-----------------//


            return camposDeBatalla;
        }

        private int updateCampoBatallaPokemon(int idPokemon) {
            //limpiar pokemones del campo de batalla
            string sql = $"UPDATE  Pokemones SET  fk_idCampoBatalla=@idCampoDeBatalla WHERE idPokemon = {idPokemon}";
            Object paramList = new { idCampoDeBatalla = 1 };
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            return affectedRows;
        }
        public int SetPokemonesBatalla(int idPokemon1, int idPokemon2) {
            //limpiar pokemones del campo de batalla
            string sql = "UPDATE  Pokemones SET  fk_idCampoBatalla=CAST(NULL As nvarchar(100)) WHERE fk_idCampoBatalla = @idCampoDeBatalla";
            Object paramList = new { idCampoDeBatalla = 1};
            int affectedRows = dbOperation.OperationExecute(sql, paramList);

            //setear pokemones seleccionados
            updateCampoBatallaPokemon(idPokemon1);
            updateCampoBatallaPokemon(idPokemon2);

            return affectedRows;
        }
    }
}