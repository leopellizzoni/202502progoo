using System;
using BibliotecaDotnet.Modelos;

namespace BibliotecaDotnet;

public class GerenciadorDeBiblioteca
{
    Livro[] todosLivros = new Livro[2];
    Usuario[] todosUsuarios = new Usuario[1];

    public GerenciadorDeBiblioteca()
    {
        InicializarValores();
    }

    private void MostrarOpcoes()
    {
        Console.WriteLine("Sistema de Biblioteca");
        Console.WriteLine("1 - Listar todos os livros");
        Console.WriteLine("2 - Listar usuários");
        Console.WriteLine("3 - Cadastrar livro");
        Console.WriteLine("4 - Cadastrar usuário");
        Console.WriteLine("99 - Sair");
        Console.Write("Informe a opção: ");
    }

    private void InicializarValores()
    {
        todosLivros[0] = new Livro("Os Inovadores", "Isaac", 01, new DateTime(2020, 01, 01));
        todosLivros[1] = new Livro("Programador Pragmático", "Andy Hunt, Dave Thomas", 02, new DateTime(2020, 02, 02));

        todosUsuarios[0] = new Usuario(1, "Usuário 1", "usuarioa1@ucs.br", "+555411111111");
    }

    private void ListarTodosLivros()
    {
        for (int i = 0; i < todosLivros.Length; i++)
        {
            todosLivros[i].ImprimirDescricao();
        }
    }

    private void ListarTodosUsuarios()
    {
        foreach (Usuario usuario in todosUsuarios)
        {
            Console.WriteLine(usuario.ObterDescricaoPublica());
        }
    }

    private void CadastrarLivro()
    {
        Console.Write("Informe o titulo: ");
        String titulo = Console.ReadLine();
        Console.Write("Informe o autor:");
        String autor = Console.ReadLine();

        Livro[] novosLivros = new Livro[todosLivros.Length + 1];

        for (int i = 0; i < todosLivros.Length; i++)
        {
            novosLivros[i] = todosLivros[i];
        }

        novosLivros[novosLivros.Length - 1] = new Livro(titulo, autor);
        
        todosLivros = novosLivros;
    }

    public void Iniciar()
    {
        int opcaoUsuario = 0;
        do
        {
            MostrarOpcoes();

            opcaoUsuario = int.Parse(Console.ReadLine());

            if (opcaoUsuario == 1)
            {
                ListarTodosLivros();
            }
            else if (opcaoUsuario == 2)
            {
                ListarTodosUsuarios();
            }
            else if (opcaoUsuario == 3)
            {
                CadastrarLivro();
            }
        } while (opcaoUsuario != 99);

    }
}
