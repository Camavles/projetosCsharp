using DesafioLivro.Autores;
using DesafioLivro.Livros;

Livro livro1 = new Livro("123-456-999", "A cor do céu");
Autor autor1 = new Autor();
autor1.Nome = "Camila Alves";
autor1.Cpf = "123.456-00";
autor1.Telefone = "13 99988-1963";

livro1.Autor = autor1;
livro1.GeneroLiterario = "Romance";
livro1.NumeroDePaginas = 185;
livro1.AnoDePublicacao = "21/01/2022";
livro1.PaisDePublicacao = "Brasil";

Console.WriteLine("Informações do Livro:");
Console.WriteLine("ISBN: " + livro1.ISBN);
Console.WriteLine("Titulo: " + livro1.Titulo);
Console.WriteLine("Número de Páginas: " + livro1.NumeroDePaginas);
Console.WriteLine("Ano de Publicação: " + livro1.AnoDePublicacao);
Console.WriteLine("País de Publicação: " + livro1.PaisDePublicacao);
Console.WriteLine();
Console.WriteLine("Nome do autor(a) " + livro1.Autor.Nome);
Console.WriteLine("Cpf do autor(a) " + livro1.Autor.Cpf);
Console.WriteLine("Telefone do autor(a) " + livro1.Autor.Telefone);

Console.WriteLine(livro1.Autor);


