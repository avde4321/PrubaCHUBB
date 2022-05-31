var urlBase = '';

function ModalEditaProducto(idproducto, codproducto, descripcion, estado) {

    $('#txtIdProductoModal').val(idproducto);
    $('#txtCodProductoModal').val(codproducto);
    $('#txtDescripcionModal').val(descripcion);
    $('#txtEstadoModal').val(estado);

    $('#BtnEditaModal').removeAttr('hidden');
    $('#TitulEdit').removeAttr('hidden');

    $('#ModalEditarProducto').modal('show');
}

function ModalInsertProducto() {
        
    $('#TitulInsert').removeAttr('hidden');
    $('#BtnInsertarModal').removeAttr('hidden');

    $('#ModalEditarProducto').modal('show');
}

function EditaProducto() {
    var producto = {
        IdProducto: $('#txtIdProductoModal').val(),
        CodProducto: $('#txtCodProductoModal').val(),
        Descripcion: $('#txtDescripcionModal').val(),
        Estado: $('#txtEstadoModal').val()
    }

    $.ajax({
        url: urlBase + '/Producto/EditaProduct/',
        type: 'PUT',
        dataType: "json",
        async: false,
        data: {
            producto
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

function InsertarProducto() {

    var now = new Date();
    var month = now.getMonth() + 1;
    var day = now.getDate();
    var fecha = now.getFullYear() + '/' + (month < 10 ? '0' : '') + month + '/' + (day < 10 ? '0' : '') + day;

    var producto = {
        IdProducto: $('#txtIdProductoModal').val(),
        CodProducto: $('#txtCodProductoModal').val(),
        Descripcion: $('#txtDescripcionModal').val(),
        Fecha: fecha,
        Estado: $('#txtEstadoModal').val()
    }

    $.ajax({
        url: urlBase + '/Producto/InsertarProduct/',
        type: 'PUT',
        dataType: "json",
        async: false,
        data: {
            producto
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

function ConsultaProducto() {

    var cod = $('#TxBuscaproducto').val()

    $.ajax({
        url: urlBase + '/Producto/ConsultProduc/',
        type: 'GET',
        dataType: "html",
        async: false,
        data: {
            codProduc: cod
        },
        success: function (data) {
            $('#TblPartProduc').html(data);
        },
        error: function (data) {

        }
    });
}

$('#TxBuscaproducto').on('change', function (e) {
    ConsultaProducto()
})

$(document).ready(function () {
    ConsultaProducto();
});