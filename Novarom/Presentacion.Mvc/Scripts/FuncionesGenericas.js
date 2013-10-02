ObtenerDatosServidor = function (url,  parametros, callback) {
    //En Construccion
    var retornado = null;
    try {

        var datosparametros = JSON.stringify(parametros, "").replace("\n", "");
        $.ajax({
            url: url,
            data: datosparametros.toString(),
            dataType: "json",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                callback(data);
            },
            error: function (request, status, error) {

                alert(request.responseText + "Click OK to continue.\n\n" + error);
            }
        });
    }
    catch (err) {
       var txt = "There was an error on this page.\n\n";
        txt += "Error description: " + err.message + "\n\n";
        txt += "Click OK to continue.\n\n";
        alert(txt);
    }



};