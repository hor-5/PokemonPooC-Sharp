//trayendo los pokemones

function getPokemonById(idPokemon){

  fetch(`https://localhost:7102/api/pokemon/${idPokemon}`)
  .then(response => response.json())
  .then(pokemon => {
      
      var tituloModal = document.getElementById("tituloModal")
      var cuerpoModal = document.getElementById("cuerpoModal")
      tituloModal.innerHTML=`${pokemon.nombre.toUpperCase()}`
      cuerpoModal.innerHTML=`
        <div class="d-flex justify-content-center">
          <img class="img-fluid rounded-circle" height='350px' width='350px' src=${pokemon.imgUrl} alt=${pokemon.descripcion} />
        </div>
        <div class="d-flex justify-content-center">
          <p>${pokemon.descripcion}</p>
        </div>
        <div class="d-flex justify-content-center">
          <h4>Evoluciones</h4>        
        </div>
        <div class="d-flex justify-content-center">               
          <p>${pokemon.evoluciones}</p>
        </div>

        <div class="d-flex justify-content-center">
          <div class="alert alert-black rounded-pill p-5"><span style="font-size:30px">${pokemon.salud} de salud</span></div>
        </div>

        <div class="d-flex justify-content-center">
          <div class="alert alert-success rounded-pill p-5"><span style="font-size:30px">${pokemon.capacidadAtaque}</span>  de ataque </div>
        </div>
        <div class="d-flex justify-content-center">
          <div class="alert alert-primary rounded-pill p-5"><span style="font-size:30px">${pokemon.capacidadDefensa}</span> de defensa</div>
        </div>

        <div class="d-flex justify-content-center">
          <div class="p-1">Peso <b>${pokemon.peso}</b> kg</div>          
          <div class="p-1">  Altura <b>${pokemon.altura}</b> m </div>
        </div>

        <div class="d-flex justify-content-center">
          <div>Pokemon de tipo <b>${pokemon.tipoPrincipal.nombreTipo.toUpperCase()}</b> </div>
        </div>
        <div class="d-flex justify-content-center" id="tipoSecundario"></div>

        `

        if(pokemon.tipoSecundario!=null){
          var divTipoSecundario = document.getElementById("tipoSecundario")
          divTipoSecundario.innerHTML = `<div>Tipo secundario <b>${pokemon.tipoSecundario.nombreTipo.toUpperCase()}</b> </div>
          `
        }
    }
    
  )



}


function getPokemones() {
    document.getElementById("pokemones").innerHTML = ``
    fetch('https://localhost:7102/api/pokemon/todos')
        .then(response => response.json())
        .then(json => json.map(pokemon => {
            var divPokemones = document.getElementById("pokemones")            
            divPokemones.innerHTML += `
<div class="col-md-6">
    <div class="card" style="border-radius:20px; margin:10px;">
    <div class="bg-image hover-overlay ripple" data-mdb-ripple-color="light" data-toggle="modal" data-target="#exampleModal"  onclick="getPokemonById(${pokemon.idPokemon})">
      <img src=${pokemon.imgUrl} class="img-fluid"/>
      <a href="#!">
        <div class="mask" style="background-color: rgba(251, 251, 251, 0.15);"></div>
      </a>
    </div>
    <div class="card-body">
      <h5 class="card-title">${pokemon.nombre.toUpperCase()}</h5>
      <p class="card-text">${pokemon.descripcion}</p>
      <h6>Tipo ${pokemon.tipoPrincipal.nombreTipo}</h6>
    </div>
  </div>
</div>
    `
        }))
}



//trayendo los entrenadores


function getEntrenadores() {
    document.getElementById("entrenadores").innerHTML = ``
    fetch('https://localhost:7102/api/entrenador/todos')
        .then(response => response.json())
        .then(json => json.map(entrenador => {
            var divEntrenadores = document.getElementById("entrenadores")            
            divEntrenadores.innerHTML += `
    <div class="card " style="border-radius:20px; margin:10px;">
    <div class="bg-image hover-overlay ripple" data-mdb-ripple-color="light" ">
      <img src=${entrenador.imgUrl} class="img-fluid"/>
      <a href="#!">
        <div class="mask" style="background-color: rgba(251, 251, 251, 0.15);"></div>
      </a>
    </div>
    <div class="card-body">
      <h5 class="card-title">${entrenador.nombre.toUpperCase()} ${entrenador.apellido.toUpperCase()}</h5>
      <p class="card-text">
        Pokemones
      </p>
      <div class="row" id=${entrenador.idEntrenador}}>
        
        <img class="img-thumbnail rounded-circle m-1" 
        src=${entrenador.aPokemones[0].imgUrl} alt=${entrenador.aPokemones[0].nombre}
        style="height:100px; width:100px;"/>            
        <img class="img-thumbnail rounded-circle m-1" 
        src=${entrenador.aPokemones[1].imgUrl} alt=${entrenador.aPokemones[1].nombre}
        style="height:100px; width:100px;"/>            
        
      </div>
    </div>
  </div>
    `
        }))
        
}


