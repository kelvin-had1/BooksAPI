# BooksAPI
Uma API (CRUD) utilizando ASP.net e EntityFramework

<h2>GET<h2/>
https://localhost:44339/api/Books
Retorna os livros.
<br>

https://localhost:44339/api/Books/{id}
Retorna o livro que o Id seja igual ao do parâmetro da URL.
<br>
  
<h2>POST<h2/>
https://localhost:44339/api/Books
<h2>O corpo da requisição deve conter o author, description e title: <br><h2/>
{
  "author": "Kelvin",
  "description": "História Real",
  "title": "Diario de Anne Frank"
}
