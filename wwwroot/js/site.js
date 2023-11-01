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
    alert($("#formulario").serialize());
    $.ajax({
        url: '/Home/AgregarReserva',
        type : 'GET',
        data: $("#formulario").serialize(),
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
