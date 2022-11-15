//trayendo los pokemones

function getPokemonById(idPokemon) {

  fetch(`https://localhost:7102/api/pokemon/${idPokemon}`)
    .then(response => response.json())
    .then(pokemon => {

      var tituloModal = document.getElementById("tituloModal")
      var cuerpoModal = document.getElementById("cuerpoModal")
      tituloModal.innerHTML = `${pokemon.nombre.toUpperCase()}`
      cuerpoModal.innerHTML = `
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

      if (pokemon.tipoSecundario != null) {
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
    .then(json => {
      var divPokemones = document.getElementById("pokemones")
      divPokemones.innerHTML=``
      json.map(pokemon => {
              
      divPokemones.innerHTML += `
<div class="col-md-6">
    <div class="card" style="border-radius:20px; margin:10px; cursor:pointer;">
      <div class="bg-image hover-overlay ripple" data-mdb-ripple-color="light" data-toggle="modal" data-target="#exampleModal"  onclick="getPokemonById(${pokemon.idPokemon})">
        
      <img src=${pokemon.imgUrl} class="img-fluid"/>
        
        <div class="mask" style="background-color: rgba(251, 251, 251, 0.15);"></div>
        
      
      <div class="card-body">
        <h5 class="card-title">${pokemon.nombre.toUpperCase()}</h5>
        <p class="card-text">${pokemon.descripcion}</p>
        <h6>Tipo ${pokemon.tipoPrincipal.nombreTipo}</h6>
      </div>
    </div>
  </div>
</div>
    `
    })
  })
}



//trayendo los entrenadores


function getEntrenadores() {
  
  fetch('https://localhost:7102/api/entrenador/todos')
    .then(response => response.json())
    .then(json => {
      var divEntrenadores = document.getElementById("entrenadores")
      divEntrenadores.innerHTML=``
      json.map(entrenador => {

      divEntrenadores.innerHTML += `
    <div class="card " style="border-radius:20px; margin:10px;">
      
    <div class="d-flex justify-content-center">
      <img src=${entrenador.imgUrl} class=" p-2 rounded-circle imgEntrenador" />
    </div>   
    
    <div class="card-body">
      <h5 class="card-title">${entrenador.nombre.toUpperCase()} ${entrenador.apellido.toUpperCase()}</h5>
      
      <div class="d-flex justify-content-start">
      

      <div class="row" id=${entrenador.idEntrenador}}>
          <p class="card-text d-flex justify-self-start">
          Pokemones
          </p>
        
        
        <img class="img-thumbnail rounded-circle m-1" onclick="redirect(${entrenador.aPokemones[0].idPokemon},${entrenador.idEntrenador})"
        src=${entrenador.aPokemones[0].imgUrl} alt=${entrenador.aPokemones[0].nombre}
        style="height:100px; width:100px;"/>
        
                   
        <img class="img-thumbnail rounded-circle m-1" onclick="redirect(${entrenador.aPokemones[1].idPokemon},${entrenador.idEntrenador})"
        src=${entrenador.aPokemones[1].imgUrl} alt=${entrenador.aPokemones[1].nombre}
        style="height:100px; width:100px;"/>
                 
        
      </div>
    </div>
    </div>
  </div>
    `
    })
  })

}

function redirect(idPokemon, idEntrenador){
  window.location.href =`./entrenar.html?idPokemon=${idPokemon}&idEntrenador=${idEntrenador}`
}

function getDataById(){
  const queryString = window.location.search;
  console.log(queryString); 
  const urlParams = new URLSearchParams(queryString);

  if(urlParams.has('idPokemon')){
    const idPokemon = urlParams.get('idPokemon')
    const idEntrenador = urlParams.get('idEntrenador')

    console.log(`El id del pokemon es ${idPokemon}`)
    var divPokemonData = document.getElementById("pokemonData")

    fetch(`https://localhost:7102/api/entrenador/${idEntrenador}/pokemon/${idPokemon}`)
    .then(response => response.json())
    .then(pokemon => {
      divPokemonData.innerHTML = `                
      <div class="row p-4 " style="background-color:#f4f0ec; border-radius: 20px;">
      <div class="col-2 ">                        
          <img 
               height="230px" 
               width="230px" 
               class="img rounded-3" 
               src=${pokemon.imgUrl} 
               alt=${pokemon.nombre}>
      </div>
      <div class="col-10 d-flex justify-content-end">
          <div class="row text-center">
              <h4>${pokemon.nombre.toUpperCase()} #${pokemon.idPokemon}</h4>                            
              <h5 id="nivelPokemon">nivel <span style="font-size:30px">${pokemon.nivel}</span></h5>
              <button onclick="entrenarPokemon(${idPokemon},${idEntrenador})" class="btn btn-sm btn-info rounded-pill">Entrenar <i class="fa-solid fa-bolt"></i></button>
          </div>
      </div>
  </div>                                  
                                  
                                  `
    })
    
  }
  if(urlParams.has('idEntrenador')){
    const idEntrenador = urlParams.get('idEntrenador')
    console.log(`el id del entrenador es ${idEntrenador}`)
    var divEntrenadorData = document.getElementById("entrenadorData")
    fetch(`https://localhost:7102/api/entrenador/${idEntrenador}`)
    .then(response => response.json())
    .then(entrenador => {
      divEntrenadorData.innerHTML=`
      <img style="border-radius: 20px;"
      height="250px" 
      width="250px" 
      class="img rounded-5" 
      src=${entrenador.imgUrl} 
      alt=${entrenador.nombre}>
 
      <h4>${entrenador.nombre} ${entrenador.apellido}</h4>
      `
    })
    
  }
}

function entrenarPokemon(idPokemon,idEntrenador){

  fetch(`https://localhost:7102/api/entrenador/${idEntrenador}/pokemon/${idPokemon}/entrenar`)
  .then(response => response.json())
  .then(resultado => {
    var elementNivel = document.getElementById("nivelPokemon")
    elementNivel.innerHTML=`nivel <span style="font-size:30px">${resultado.nivel}</span>`
    
    var divRespuesta = document.getElementById("respuesta")    
    divRespuesta.innerHTML=`${resultado.mensaje} ahora es nivel ${resultado.nivel}`
    var displayRespuesta = document.getElementById("displayRespuesta")
    displayRespuesta.classList.remove("no-display");

    setTimeout(() => {
      displayRespuesta.classList.add("no-display");
    }, 2000)

  })
  
}

//auxiliar
function volver(){
  window.location.href =`./pokemon.html`
}
function batalla(){
  window.location.href =`./batalla.html`
}

