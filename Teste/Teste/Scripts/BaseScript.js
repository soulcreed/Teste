$(document).ready(function () {
    $('#btnSalvarCidade').click(function () {
        inserirDados('Cidades');
    });

    $('#btnSalvarEstado').click(function () {
        inserirDados('Estados');
    });
    consultarDados('Estados')
});

var Estado = {
    Codigo: 0,
    Nome:'',
    Sigla:'',
    Pais:'',
    Regiao:''
}
var Cidade = {
    Codigo: 0,
    Estado: Estado,
    Nome: '',
    Capital: false
}

function carregaObjeto(controller) {
    var objectData = null;
    if (controller == "Cidades") {
        Estado.Codigo = $("#cmbEstado").val();
        Cidade.Estado = Estado;
        Cidade.Nome = $("#Nome").val();
        Cidade.Capital = $("#Capital").val();
        objectData = Cidade;
    }
    else {
        Estado.Nome = $("#Nome").val();
        Estado.Pais = $("#Pais").val();
        Estado.Regiao = $("#Regiao").val();
        Estado.Sigla = $("#Sigla").val();
        objectData = Estado;
    }
    return objectData;
}

function definiUrlController(controller, action) {
    return urlContent + controller + '/' + action;
}

function inserirDados(controller) {
    var objData = carregaObjeto(controller);
    $.ajax({
        async: true,
        cache: false,
        url: definiUrlController(controller, 'Create'),
        type: 'post',
        data: '{ cidade: '+ objData +', ' + 'estado: '+ objData.Estado +'}'
        ,
        success: function (data) {
        },
        error: function (xhr, err) {
            exibeMensagem('Inserindo dados...', err);
        }
    });
}

function alterarDados(controller) {
    var dataObjct = carregaObjeto(controller);
    $.ajax({
        async: false,
        cache: false,
        url: definiUrlController(controller, 'Details'),
        type: 'post',
        data: dataObjct.Codigo,
        success: function (data) {
        },
        error: function (xhr, err) {
            exibeMensagem('Buscando dados...', err);
        }
    });
}

function consultarDados(controller) {
    var dataObjct = carregaObjeto(controller);
    $.ajax({
        async: false,
        cache: false,
        url: definiUrlController(controller, 'Details'),
        type: 'post',
        data: dataObjct.Codigo,
        success: function (data) {
            preencheComboEstado(data);
        },
        error: function (xhr, err) {
            exibeMensagem('Buscando dados...', err);
        }
    });
}

function deletarDados() {
    $.ajax({
        async: false,
        cache: false,
        url: definiUrlController('', ''),
        type: 'post',
        data: '',
        success: function (data) {
        },
        error: function (xhr, err) {
            exibeMensagem('Deletando dados...', err);
        }
    });
}

function exibeMensagem(titulo, mensagem) {
    preparaMensagem(titulo, mensagem, {
        "OK": function () {
            $(this).dialog("close");
        }
    }, false);
}

function preparaMensagem(titulo, mensagem) {
    $('#dialogMensagem').html(mensagem);
    $('#dialogMensagem').dialog({
        autoOpen: false,
        modal: true,
        title: titulo,
        width: 450,
        height: 180,
        closeOnEscape: false
    });
    $('#dialogMensagem').dialog('open');
}

function preencheComboEstado(data) {
    $.each(data, function (i, item) {
        $('#cmbEstado').append($('<option>', {
            value: item.Codigo,
            text: item.Nome
        }));
    });
}





