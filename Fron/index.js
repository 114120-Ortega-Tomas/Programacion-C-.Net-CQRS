$(document).ready(function(){
    cargartabla1();
    cargartabla2();
    
})

const cargartabla1=()=>{
    fetch("https://localhost:7200/api/Deposito/GetAll")
    .then(respuesta=>(respuesta.json()))
    .then(respuesta=>{
        if(respuesta.ok)
        {
            var tabla= document.getElementById("tabla")
            respuesta.listDepositos.forEach(element => {
                var fila = document.createElement("tr")
                fila.innerHTML+=`<td>${element.id}</td>`
                fila.innerHTML+=`<td>${element.name}</td>`
                fila.innerHTML+=`<td>${element.activo}</td>`
                fila.innerHTML+=`<td>${element.metrosCuadrados}</td>`
                fila.innerHTML+=`<td>${element.calle}</td>`
                fila.innerHTML+=`<td>${element.numero}</td>`
                fila.innerHTML+=`<td>${element.barrio}</td>`
                fila.innerHTML+=`<td>${element.ciudad}</td>`
                fila.innerHTML+=`<td>${element.pais}</td>`
                tabla.append(fila)
            });
        }
        else alert("algo salio mal")
    })
}

const cargartabla2=()=>{
    fetch("https://localhost:7200/api/Deposito/GetAllArgentina")
    .then(respuesta=>(respuesta.json()))
    .then(respuesta=>{
        if(respuesta.ok)
        {
            var tabla= document.getElementById("tabla2")
            respuesta.listDepositos.forEach(element => {
                var fila = document.createElement("tr")
                fila.innerHTML+=`<td>${element.id}</td>`
                fila.innerHTML+=`<td>${element.name}</td>`
                fila.innerHTML+=`<td>${element.activo}</td>`
                fila.innerHTML+=`<td>${element.metrosCuadrados}</td>`
                fila.innerHTML+=`<td>${element.calle}</td>`
                fila.innerHTML+=`<td>${element.numero}</td>`
                fila.innerHTML+=`<td>${element.barrio}</td>`
                fila.innerHTML+=`<td>${element.ciudad}</td>`
                fila.innerHTML+=`<td>${element.pais}</td>`
                tabla.append(fila)
            });
        }
        else alert("algo salio mal")
        
    })
    
    
    
    
}

const argentina=()=>{
    var filas = document.getElementById('tabla2').getElementsByTagName('tr').length - 1;
    console.log(filas)
    if(filas>3)
    {
        alert("Existen " + filas + " depositos Argentinos")
    }  
}
const argentina1=()=>{
    var filas = document.getElementById('tabla2').getElementsByTagName('tr').length - 1;
    console.log(filas)
    if(filas==1)
    {
        var div = document.getElementById("arg")
        var label = document.createElement("div")
        label.innerHTML+=`<label for="" style="color: red; margin-left: 300px;">Existe un solo deposito Argentino</label>`
        div.append(label)
    } 
    
        
}