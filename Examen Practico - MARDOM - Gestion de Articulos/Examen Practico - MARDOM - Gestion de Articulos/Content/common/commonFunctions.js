//carga url en modalbody
function loadBody(idbody, url)
{
    $(idbody).load(url);
}

function addDetailsPagos(buttonid, tableid) {
    //obtenemos el valor de los input
 
        var Pago_Id = document.getElementById("Pago_Id");
        var Total_pago = document.getElementById("Total_pago").value;

        var i = 1; //contador para asignar id al boton que borrara la fila
        var fila = '<tr id="row' + i + '"><td>' + Pago_Id.value + '</td><td>' + Total_pago + '</td><td><button type="button" name="remove" id="' + i + '" class="btn btn-danger btn_remove">Quitar</button></td></tr>'; //esto seria lo que contendria la fila

        i++;

        $(tableid + ' tr:first').after(fila);

        //le resto 1 para no contar la fila del header
        Pago_Id.value = "";
        Total_pago = "";

  
    $(document).on('click', '.btn_remove', function () {
        var button_id = $(this).attr("id");
        //cuando da click obtenemos el id del boton
        $('#row' + button_id + '').remove(); //borra la fila
        //limpia el para que vuelva a contar las filas de la tabla
        var nFilas = $(tableid + " tr").length;
    });
}
