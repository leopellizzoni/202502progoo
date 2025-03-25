using BibliotecaDotnet.Modelos;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Biblioteca");

        Livro[] todosLivros = new Livro[2];
        Livro livro1 = new Livro("Titulo do Livro 1", "Autor Livro 1", 01, new DateTime(2020, 01, 01));
        Livro livro2 = new Livro("Titulo do Livro 2", "Autor Livro 2", 02, new DateTime(2020, 02, 02));
        
        Usuario usuario1 = new Usuario(1, "Usuário 1", "usuarioa1@ucs.br", "+555411111111");

    }
}