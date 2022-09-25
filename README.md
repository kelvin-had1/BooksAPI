# BooksAPI
Uma API (CRUD) utilizando ASP.net e EntityFramework

#GET
https://localhost:44339/api/Books <br>
Retorna os livros.
<br><br>

https://localhost:44339/api/Books/{id} <br>
Retorna o livro que o Id seja igual ao do parâmetro da URL.
<br><br>
  
#POST
https://localhost:44339/api/Books
<h2>O corpo da requisição deve conter o author, description e title: <br><h2/>
{
  "author": "Kelvin",
  "description": "História Real",
  "title": "Diario de Anne Frank"
}
