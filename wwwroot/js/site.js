function EliminarReserva(mail)
{
    $.ajax({
        url: '/Home/EliminarReserva',
        type : 'GET',
        data: {mail},
        dataType: 'int',

        success: function(Eliminar) {
            $("#texto_informacion").html("hola");  
            console.log(mail)
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
            $("#texto_informacion").html($("#formulario").serialize());    
            /// mostrar el resultado del form lindo      
        }
    });

}


