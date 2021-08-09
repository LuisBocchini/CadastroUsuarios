// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
var response = {
    erro: false,
    mensagem: ""
}

function FecharModal() {
    let modal = document.querySelector('.modal-container')
    modal.style.display = "none";
}

function FecharModalPergunta() {
    let modal = document.querySelector('#modal-pergunta')
    modal.style.display = "none";
}

function ModalMensagem(mensagem) {
    let modal_container = document.querySelector('.modal-container')
    modal_container.style.display = "flex";
    document.querySelector('.mensagem').innerText = mensagem
}

function Post(url, body) {
    fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/x-www-form-urlencoded",
        },
        body: body,
    })
        .then((response) => response.json())
        .then((data) => {
            if (data == true) {
                ModalMensagem("Operação realizada com sucesso")
            }
        })
        .catch((error) => {
        });
}
// Write your JavaScript code.
