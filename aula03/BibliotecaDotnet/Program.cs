using BibliotecaDotnet.Modelos;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Biblioteca");

        Livro livro1 = new Livro();
        livro1.Autor = "Autor Livro 1";
        livro1.Titulo = "Titulo do Livro 1";
        livro1.ISBN = 01;
        livro1.DataDePublicacao = new DateTime(2020, 01, 01);

        Livro livro2 = new Livro();
        livro2.Autor = "Autor Livro 2";
        livro2.Titulo = "Titulo do Livro 2";
        livro2.ISBN = 02;
        livro2.DataDePublicacao = new DateTime(2020, 02, 02);

    }
}