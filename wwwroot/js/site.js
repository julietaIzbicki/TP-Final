function EliminarReserva(id)
{
    $.ajax({
        url: '/Home/EliminarReserva',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success: function(Eliminar) {
            console.log(Eliminar);
            /*const inf = "hola"
            $("#modalTittle").html("Mas informacion de la serie");
            $("#texto_informacion").html(inf);
            */
        }
    });
}


function EnviarFormulario()
{
    // 
    $.ajax({
        url: '/Home/AgregarReserva',
        type : 'GET',
        data: $("#formulario").serialize(),
        dataType: 'json',

        success: function(Confirmar) {
            alert($("#formulario").serialize());            
            /*const inf = "hola"
            $("#modalTittle").html("Mas informacion de la serie");
            $("#texto_informacion").html(inf);
            */
        }
    });

}

let items = document.querySelectorAll('.carousel .carousel-item')

items.forEach((el) => {
    const minPerSlide = 4
    let next = el.nextElementSibling
    for (var i=1; i<minPerSlide; i++) {
        if (!next) {
            // wrap carousel by using first child
        	next = items[0]
      	}
        let cloneChild = next.cloneNode(true)
        el.appendChild(cloneChild.children[0])
        next = next.nextElementSibling
    }
})
