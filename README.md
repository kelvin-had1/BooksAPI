# BooksAPI
Uma API (CRUD) utilizando ASP.net e EntityFramework

#GET
<li>https://localhost:44339/api/Books<li/>
Retorna os livros.
  
<li>https://localhost:44339/api/Books/{id}</li>
Retorna o livro que o Id seja igual ao do parâmetro da URL.
  
  
#POST
<li>https://localhost:44339/api/Books<li/>
<h2>O corpo da requisição deve conter o author, description e title: <br><h2/>
{
  "author": "Kelvin",
  "description": "História Real",
  "title": "Diario de Anne Frank"
}
