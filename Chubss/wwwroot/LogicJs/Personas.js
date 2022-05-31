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

function MostrarModalEdit(idPersona, ident, nombre, telefono, edad) {
    $('#txtIdPersonaModal').val(idPersona);
    $('#txtIdentificacionModal').val(ident);
    $('#txtNombreCompModal').val(nombre);
    $('#txtTelefonoModal').val(telefono);
    $('#txtEdadModal').val(edad);

    $('#ModalEditarPerson').modal('show');
}

function inseratrpersonas() {

    var now = new Date();
    var month = now.getMonth() + 1;
    var day = now.getDate();
    var fecha = now.getFullYear() + '/' + (month < 10 ? '0' : '') + month + '/' + (day < 10 ? '0' : '') + day;

    var producto = {
        IdPersonaProducto: 0,
        IdPersona: 0,
        IdProducto: $('#txtProducto').val(),
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
        IdProducto: $('#txtProductoModal').val(),
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

function ConsultaPersona() {

    var ident = $('#TxBuscaPersona').val()

    $.ajax({
        url: urlBase + '/personas/ConsulPersona/',
        type: 'GET',
        dataType: "html",
        async: false,
        data: {
            identificacion: ident
        },
        success: function (data) {
            $('#TblPartPerson').html(data);
        },
        error: function (data) {

        }
    });
}


function EditaPersona() {

    var Persona = {
        IdPersona: $('#txtIdPersonaModal').val(),
        Identificacion: $('#txtIdentificacionModal').val(),
        NombreCliente: $('#txtNombreCompModal').val(),
        Telefono: $('#txtTelefonoModal').val(),
        Edad: $('#txtEdadModal').val(),
        Fecha: null,
        Estado: $('#txtEstadoModal').val()
    };

    $.ajax({
        url: urlBase + '/personas/EditPerson/',
        type: 'PUT',
        dataType: "json",
        async: false,
        data: {
            Persona
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

$('#TxBuscaPersona').on('change',function (e) {
    if ($('#TxBuscaPersona').val().length == 0||$('#TxBuscaPersona').val().length == 10 || $('#TxBuscaPersona').val().length == 13 || $('#TxBuscaPersona').val().length == 15) {
        ConsultaPersona()
    }
})

$(document).ready(function () {
    ConsultaPersona();
});