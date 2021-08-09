function VizualizarUsuario(usuario) {
    let usuarioId = usuario.closest('tr').id
    let url = window.location.origin + "/CadastroUsuarios?usuarioId=" + usuarioId

    fetch(
        window.location.replace(url),
    )
        .then(function (response) {
            return response.json();
        })
        .then(function (data) {

        });

}

function EditarUsuario(usuario) {
    let usuarioId = usuario.closest('tr').id
    let url = window.location.origin + "/CadastroUsuarios?usuarioId=" + usuarioId + "&editar=" + true

    fetch(
        window.location.replace(url),
    )
        .then(function (response) {
            return response.json();
        })
        .then(function (data) {

        });

}

function ExcluirUsuario() {
    let usuarioId = document.querySelector('#modal-pergunta').getAttribute('usuarioId')
    let url = window.location.origin + "/Usuario" + "/" + "ExcluirUsuario?usuarioId=" + usuarioId

    fetch(url, {
        method: 'DELETE',
    })
        .then(function (response) {
            return response.json();
        })
        .then(function (data) {
            if (data == true) {
                window.location.href = window.location.origin + "/Usuario"
            }
        });
}

function AbrirModal(usuario) {
    let usuarioId = usuario.closest('tr').id
    let modal = document.querySelector('#modal-pergunta')
    modal.style.display = "flex";
    modal.setAttribute('usuarioId', usuarioId)
}
