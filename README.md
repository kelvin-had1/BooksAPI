# BooksAPI
Uma API (CRUD) utilizando ASP.net e EntityFramework

<h2>GET<h2/>
https://localhost:44339/api/Books <br>
Retorna os livros.
<br><br>

https://localhost:44339/api/Books/{id} <br>
Retorna o livro que o Id seja igual ao do parâmetro da URL.
<br><br>
  
<h2>POST<h2/>
https://localhost:44339/api/Books <br>
O corpo da requisição deve conter o author, description e title: <br>
{
  "author": "Kelvin", <br>
  "description": "História Real", <br>
  "title": "Diario de Anne Frank" <br>
}
