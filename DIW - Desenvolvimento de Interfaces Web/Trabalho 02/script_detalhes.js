const params = new URLSearchParams(location.search)
let id = params.get('id')
let url = ''

const init = () => {
    let xhr = new XMLHttpRequest()
    let url = `https://api.themoviedb.org/3/movie/${id}?api_key=1580f580f1594cc8408241ed10daefdd&language=pt-BR`
    xhr.onload = mostrarFilmes
    xhr.onerror = mostraErro
    xhr.open ('GET', url, true)
    xhr.send()
}

const mostraErro = (data) => {
    alert('Error')
}

const mostrarFilmes = (data) => {
    let filme = JSON.parse(data.target.response)
    document.getElementById("divDetalheFilme").innerHTML = `
    <h1>${filme.title}</h1>
    <div class="card text-bg-dark shadow p-3 mb-5 rounded mb-3" style="max-width: 1000px;">
        <div class="row g-0">
            <div class="col-md-4">
            <img src="https://image.tmdb.org/t/p/w500${filme.poster_path}" class="img-fluid rounded-start" alt=" IMAGEM NÃO ENCONTRADA">
            </div>
            <div class="col-md-8">
            <div class="card-body">
                <h5 class="card-title">${filme.title}</h5>
                <p class="card-text" id = "descricao"></p>
                <p class="card-text" id = "lancamento"></p>
                <p class="card-text" id = "generos"></p>
                <p class="card-text" id = "nota"></p>
                <p class="card-text" id = "producao"></p>
                <p class="card-text" id = "site"></p>
            </div>
            </div>
        </div>
    </div>
    `   
    siteHtml = '<b>Site Oficial:</b> '
    if (filme.homepage == '') {
        siteHtml += 'SEM DADOS !'
    } else {
        siteHtml += `<a href=${filme.homepage}>${filme.homepage}</a>`
    }
    document.getElementById('site').innerHTML = siteHtml

    descricaoHtml = '<b>Sinopse:</b> '
    if (filme.overview == '') {
        descricaoHtml += 'SEM DADOS !'
    } else {
        descricaoHtml += filme.overview
    }
    document.getElementById('descricao').innerHTML = descricaoHtml

    lancamentoHtml = '<b>Data de Lançamento:</b> '
    if (filme.release_date == '') {
        lancamentoHtml += 'SEM DADOS !'
    } else {
        lancamentoHtml += filme.release_date
    }
    document.getElementById('lancamento').innerHTML = lancamentoHtml

    generosHtml = '<b>Gêneros:</b> '
    if (filme.genres == '') {
        generosHtml += 'SEM DADOS !'
    } else {
        for (let i = 0; i < filme.genres.length; i++) {
            generosHtml += filme.genres[i].name + ' | '
        }
    }
    document.getElementById('generos').innerHTML = generosHtml

    producaoHtml = '<b>Empresas de Produção:</b> '
    if (filme.production_companies == '') {
        producaoHtml += 'SEM DADOS !'
    } else {
        for (let i = 0; i < filme.production_companies.length; i++) {
            producaoHtml += filme.production_companies[i].name + ' | '
        }
    }
    document.getElementById('producao').innerHTML = producaoHtml

    notaHtml = '<b>Nota:</b> '
    if (filme.vote_average == '0') {
        notaHtml += 'SEM DADOS !'
    } else {
        notaHtml += filme.vote_average
    }
    document.getElementById('nota').innerHTML = notaHtml

}

document.body.onload = init