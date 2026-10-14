namespace AtividadePOO2.Core;

public class Livro
{
    public string Titulo { get; private set; }
    public string AutorDoLivro { get; private set; }
    public string Genero { get; private set; }
    public string Idioma { get; private set; }
    public int QuantidadeDePaginas { get; private set; }

    public Livro(string titulo, string autorDoLivro, string genero, string idioma, int quantidadeDePaginas)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("Título é obrigatório.");

        if (string.IsNullOrWhiteSpace(autorDoLivro))
            throw new ArgumentException("Autor é obrigatório.");

        if (string.IsNullOrWhiteSpace(genero))
            throw new ArgumentException("Gênero é obrigatório.");

        if (string.IsNullOrWhiteSpace(idioma))
            throw new ArgumentException("Idioma é obrigatório.");

        if (quantidadeDePaginas <= 0)
            throw new ArgumentException("Quantidade de páginas deve ser maior que zero.");

        Titulo = titulo;
        AutorDoLivro = autorDoLivro;
        Genero = genero;
        Idioma = idioma;
        QuantidadeDePaginas = quantidadeDePaginas;
    }
}