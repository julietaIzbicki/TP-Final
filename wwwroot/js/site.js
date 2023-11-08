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

        success: function(confirmar) {             
            /// $("#texto_informacion").html($("#formulario").serialize());    
            /// mostrar el resultado del form lindo
        }
    });

}

$(document).ready(function() {
    $('#confirmarReservaBtn').click(function() {
        window.location.href = '/Home/ReservaConfirmada';
    });
});
