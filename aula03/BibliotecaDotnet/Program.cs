using System.Runtime.InteropServices;
using BibliotecaDotnet.Modelos;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Biblioteca");
        Console.WriteLine("1 - Listar todos os livros");
        Console.WriteLine("2 - Listar usuários");
        Console.WriteLine("3 - Cadastrar livro");
        Console.WriteLine("4 - Cadastrar usuário");

        Livro[] todosLivros = new Livro[2];
        todosLivros[0] = new Livro("Os Inovadores", "Isaac", 01, new DateTime(2020, 01, 01));
        todosLivros[1] = new Livro("Programador Pragmático", "Andy Hunt, Dave Thomas", 02, new DateTime(2020, 02, 02));

        Usuario[] todosUsuarios = new Usuario[1];
        todosUsuarios[0] = new Usuario(1, "Usuário 1", "usuarioa1@ucs.br", "+555411111111");

        int opcaoUsuario = int.Parse(Console.ReadLine());

        if (opcaoUsuario == 1)
        {
            for(int i = 0; i < todosLivros.Length; i++)
            {
                todosLivros[i].ImprimirDescricao();
            }
        }
    }
}