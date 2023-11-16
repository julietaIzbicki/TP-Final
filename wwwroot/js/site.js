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

function Likear(id)
{
    $.ajax({
        url: '/Home/Likeando',
        type : 'GET',
        data: {id},

        success: function(like) {             
            const likesElement = document.getElementById(id);
            likesElement.innerText = parseInt(likesElement.innerText) + 1;
        }
    });
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