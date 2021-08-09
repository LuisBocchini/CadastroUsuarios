function CadastrarUsuario() {

    let validarCampos = ValidarCampos();
    if (validarCampos.erro == true) {
        return ModalMensagem(validarCampos.mensagem)
    }

    let nome = document.querySelector('#nome').value
    let email = document.querySelector('#email').value
    let cpf = document.querySelector('#cpf').value
    let nascimento = document.querySelector('#dataNascimento').value
    let cep = document.querySelector('#cep').value
    let logradouro = document.querySelector('#rua').value
    let complemento = document.querySelector('#complemento').value
    let bairro = document.querySelector('#bairro').value
    let cidade = document.querySelector('#cidade').value
    let estado = document.querySelector('#uf').value
    let usuarioId = document.querySelector('.form-usuario').id
    let enderecoId = document.querySelector('.form-usuario').getAttribute('enderecoId')


    const usuario =
    {
        "Id": usuarioId,
        "Nome": nome,
        "Email": email,
        "CPF": cpf,
        "DataNascimento": nascimento,
        "Cep": cep,
        "Logradouro": logradouro,
        "Complemento": complemento,
        "Bairro": bairro,
        "Cidade": cidade,
        "Estado": estado,
        "EnderecoId": enderecoId
    }

    let url = window.location.origin + "/" + "CadastroUsuarios" + "/" + "SalvarUsuario"
    var body = prepareData(usuario)
    Post(url, body)
}

//Tratando o json
function prepareData(data) {
    if (typeof data == 'string') return data;
    var pairs = Object.keys(data).map(function (key) {
        return [key, data[key]].map(encodeURIComponent).join('=');
    }).join('&');

    return pairs;
}

function ValidarCampos() {
    let nome = document.querySelector('#nome').value
    let email = document.querySelector('#email').value
    let cpf = document.querySelector('#cpf').value
    let nascimento = document.querySelector('#dataNascimento').value
    let cep = document.querySelector('#cep').value
    let logradouro = document.querySelector('#rua').value
    let complemento = document.querySelector('#complemento').value
    let bairro = document.querySelector('#bairro').value
    let cidade = document.querySelector('#cidade').value
    let estado = document.querySelector('#uf').value

    if (nome == "" || email == "" || cpf == "" || nascimento == "" || cep == "" || logradouro == "" || complemento == "" || bairro == "" || cidade == "" || estado == "") {
        response.erro = true
        response.mensagem = "Informe todos os campos..."
        return response
    }
    response.erro = false
    return response
}

