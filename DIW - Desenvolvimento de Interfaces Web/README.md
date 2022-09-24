# Trabalho 02

Nesse trabalho, vamos dar vida ao layout desenvolvido no trabalho anterior. Vamos apresentar informações reais sobre os filmes obtidas dinamicamente a partir da integração com a <a href="https://developers.themoviedb.org/3/getting-started/introduction">API The Movie DB</a>.

Esta API oferece diversas funcionalidades por meio de endpoints no padrão RESTful.  Você precisará criar uma conta para receber a uma chave (API Key) utilizada em todas as requisições.

Neste trabalho, pode-se evoluir o layout do portal de filmes do trabalho anterior ou começar um projeto de layout do zero. Essa decisão fica a cargo de cada aluno. Você deverá montar um layout sobre filmes e apresentar funcionalidades para os seus usuários que são pessoas aficionadas por cinema e séries de TVs.

Dentre as funcionalidades providas pela **API The Movie DB**, destacamos os seguintes recursos que podem ser utilizadas no seu projeto:  

- <a href="https://developers.themoviedb.org/3/movies/get-popular-movies">Filmes populares</a> - fornece uma lista atualizada dos filmes mais procurados;
- <a href="https://developers.themoviedb.org/3/movies/get-latest-movie">Últimos filmes</a> - fornece uma lista dos filmes mais recentes;
- <a href="https://developers.themoviedb.org/3/movies/get-now-playing">Filmes no Cinema</a> - fornece uma lista de filmes em cartaz nos cinemas.

## Requisitos do Projeto

O site que você fará deve atender aos seguintes requisitos: 

- o site deve ser publicado em um ambiente da Internet (Repl.it, GitHub Pages, Heroku, Netlify ou outro a sua escolha); 
- o site deverá ser responsivo permitindo a visualização em um celular de forma adequada;
- o site deve ter uma **Home-Page (index.html)** com a listagem dinâmica de filmes/séries obtidos via API **The Movie DB** à escolha do aluno que pode ser qualquer das alternativas como: (1) filmes populares, (2) filmes no cinema, (3) séries de TV ou outra listagem a ser projetada pelo aluno a partir da mesma API. Nessa página inicial, devem ser obedecidos os seguintes requisitos:
    - para cada item da listagem devem ser exibidos um mínimo de três (3) dados textuais obtidos por meio da API que descrevam sucintamente o referido item (Ex: título, data, descrição, categoria, etc);
    - para cada item da listagem, deve ser exibida uma imagem ilustrativa do referido item;
    - para cada item da listagem, deve haver um link que leve o usuário para uma **Página de Detalhes do filme/serie (detalhes.html)** com mais informações sobre o item.
- o site deve apresentar uma **Página de pesquisa (pesquisa.html)** ou funcionalidade integrada à home-page no cabeçalho que permita ao usuário informar um texto e localizar informações providas pela API do The Movie DB que devem ser apresentadas como resultado da pesquisa. 
Na página de pesquisa, devem ser obedecidos os seguintes requisitos:
    - o resultado da pesquisa poderá ser paginado ou não;
    - o resultado deve mostrar uma lista de itens tal qual a home-page com imagem e textos que descrevam o item retornado;
    - os itens do resultado devem ter um link que ao ser acionado, leve o usuário para a página original do referido item, cujo link é obtido por meio da API do The Movie DB.

# <a href="https://cinefilmes.netlify.app">Site</a>