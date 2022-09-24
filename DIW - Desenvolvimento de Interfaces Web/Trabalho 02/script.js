const mostrarFilmes = (data) => {
    let dadosFilmes = JSON.parse(data.target.response)
    let dadosHtml = ''
    for (let i = 0; i < dadosFilmes.results.length; i++) {
        let filme = dadosFilmes.results[i]
        let descricao = ''
        if (filme.overview == '') {
            descricao = '<b>Sinopse:</b> SEM DADOS !'
        } else {
            descricao = `<b>Sinopse:</b> ${filme.overview}`
        }

        let lancamento = ''
        if (filme.release_date == '') {
            lancamento = '<b>Data de Lançamento:</b> SEM DADOS !'
        } else {
            lancamento = `<b>Data de Lançamento:</b> ${filme.release_date}`
        }
        dadosHtml += `
        <div class="card text-bg-dark col-12 col-sm-8 col-md-4 col-lg-3 shadow p-3 mb-5 rounded">
            <img src="https://image.tmdb.org/t/p/w500${filme.poster_path}" class="card-img-top" alt=" IMAGEM NÃO ENCONTRADA">
            <div class="card-body">
                <h5 class="card-title">${filme.title}</h5>
                <p class="card-text">${descricao}</p>
                <p class="card-text">${lancamento}</p>
                <a href="detalhes_filmes.html?id=${filme.id}" class="btn btn-outline-light">Veja Mais</a>
            </div>
        </div>
        `
    }
    document.getElementById('divListaFilmes').innerHTML = dadosHtml
}

const mostraErro = (data) => {
    alert('Error')
}

const init = () => {
    let xhr = new XMLHttpRequest()
    let url = 'https://api.themoviedb.org/3/movie/popular?api_key=1580f580f1594cc8408241ed10daefdd&language=pt-BR'
    xhr.onload = mostrarFilmes
    xhr.onerror = mostraErro
    xhr.open ('GET', url, true)
    xhr.send()
}

form.addEventListener('submit', (e) => {
    e.preventDefault();
    var pesquisa = $('#pesquisa').val()
    let titulo = `Resultados para: "${pesquisa}"`
    document.getElementById('titulo').innerHTML = titulo
    var urlPesquisa = `https://api.themoviedb.org/3/search/movie?api_key=1580f580f1594cc8408241ed10daefdd&language=pt-BR&query=${pesquisa}`
    let xhr = new XMLHttpRequest()
    xhr.onload = mostrarFilmes
    xhr.onerror = mostraErro
    xhr.open ('GET', urlPesquisa, true)
    xhr.send()
})

document.body.onload = init