var urlBase = '';

function validaNumero(evento) {//permite digitar solo numeros
    var key = evento.keyCode || evento.which;
    var tecla = String.fromCharCode(key).toLowerCase();
    var letras = "1234567890";
    var especiales = [8, 37, 39];

    tecla_especial = false;
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (letras.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function validarLetras(evento) {//permite digitar solo letras
    //---------------------------------------------------------------------------------------//  
    var key = evento.keyCode || evento.which;
    var tecla = String.fromCharCode(key).toLowerCase();
    var letras = " áéíóúabcdefghijklmnñopqrstuvwxyzÁÉÍÓÚABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
    var punto = ".";
    var especiales = [8, 37, 39, 46];

    tecla_especial = false;
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (letras.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
}

function MostrarModal(identi) {
    $('#txIdentificacion').val(identi);
    $('#modal-default').modal('show');
}

function MostrarModalCons(identi) {
    $('#txIdentificacion').val(identi);
    ConsultaProcto();
    $('#ModalProductoCons').modal('show');
}

function inseratrpersonas() {

    var now = new Date();
    var month = now.getMonth() + 1;
    var day = now.getDate();
    var fecha = now.getFullYear() + '/' + (month < 10 ? '0' : '') + month + '/' + (day < 10 ? '0' : '') + day;

    var producto = {
        IdPersonaProducto: 0,
        IdPersona: 0,
        IdCatalagoProducto: $('#txtProducto').val(),
        Prima: $('#txtPrima').val(),
        Fecha: fecha,
        Estado: 'A',
    }

    var Persona = {
        Identificacion: $('#txtIdentificacion').val(),
        NombreCliente: $('#txtNombreComp').val(),
        Telefono: $('#txtTelefono').val(),
        Edad: $('#txtEdad').val(),
        Fecha: fecha,
        Estado: 'A'
    };

    $.ajax({
        url: urlBase + '/personas/Insertar/',
        type: 'POST',
        dataType: "json",
        async: false,
        data: {
            Persona, producto
        },
        success: function (data) {
            alert(data);
            window.location.reload(true);
        },
        error: function (data) {
            alert(data);
        }
    });
}

function inseratrProductoModal() {


    var now = new Date();
    var month = now.getMonth() + 1;
    var day = now.getDate();
    var fecha = now.getFullYear() + '/' + (month < 10 ? '0' : '') + month + '/' + (day < 10 ? '0' : '') + day;

    var identificacion = $('#txIdentificacion').val()

    var producto = {
        IdPersonaProducto: 0,
        IdPersona: 0,
        IdCatalagoProducto: $('#txtProductoModal').val(),
        Prima: $('#txtPrimaModal').val(),
        Fecha: fecha,
        Estado: 'A',
    }

    $.ajax({
        url: urlBase + '/personas/InsertarProducto/',
        type: 'POST',
        dataType: "json",
        async: false,
        data: {
            producto, Ident: identificacion
        },
        success: function (data) {
            alert(data);
            window.location.reload(true);
        },
        error: function (data) {
            alert(data);
        }
    });
}

function ConsultaProcto() {

    var identificacion = $('#txIdentificacion').val()

    $.ajax({
        url: urlBase + '/personas/ConstProducto/',
        type: 'GET',
        dataType: "html",
        async: false,
        data: {
            Ident: identificacion
        },
        success: function (data) {
            $('#ModalConsltProducto').html(data);
        },
        error: function (data) {
            
        }
    });
}