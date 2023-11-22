//**********************************************   JS   **********************************************/

$(document).ready(function() {
    $('#confirmarReservaBtn').click(function() {
        window.location.href = '/Home/ReservaConfirmada';
    });
});



document.getElementById("Edad").addEventListener('keyup', (event) => {

    const edad = document.getElementById("Edad").value;
    let ok2 = false;

    if (edad > 16) {
        Edad.style.background = "green";        
        ok2 = true;
    } else {
        Edad.style.background = "red";        
    }
});

/**********************************************   AJAX   **********************************************/

function Likear(checkbox, id)
{
    /*
    Opcion 1. Chequear con JS si el input esta chequeado.
    Opcion 2. llamadar a likeando pasando como parametro si esta chequeado o no, que el likeando devuelva la cantidad de likes y mostrar eso
   
    if ($('#miCheckbox').is(':checked')) {
        // Hacer algo si no está marcado
        console.log('El checkbox no está marcado');
    } else {
        $.ajax({
            url: '/Home/Likeando',
            type : 'GET',
            data: {id},
    
            success: function(like) {             
                const likesElement = document.getElementById(id);
                likesElement.innerText = parseInt(likesElement.innerText) + 1;
            }
        });
    } */
    if ($(checkbox).is(':checked')) {
        $.ajax({
            url: '/Home/Likeando',
            type: 'GET',
            data: { id: id },
            success: function(like) {
                const likesElement = document.getElementById(id);
                likesElement.innerText = parseInt(likesElement.innerText) + 1;
            }
        });
    } else {
        const likesElement = document.getElementById(id);
        likesElement.innerText = parseInt(likesElement.innerText) - 1;
    }
}

function EliminarReserva()
{
    mail=$("#Mail").val();
    $.ajax({
        url: '/Home/EliminarReserva',
        type : 'GET',
        data: {mail},
        
        success: function(Eliminar) {
            window.location.href = '/Home/ReservaEliminada'        
        }
    });
}

function EnviarFormulario()
{
    $.ajax({
        url: '/Home/AgregarReserva',
        type : 'GET',
        data: $("#formulario").serialize(),
        dataType: 'json',  

        success: function(confirmar) {}
    });

}