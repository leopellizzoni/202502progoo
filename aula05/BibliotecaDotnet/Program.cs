using System.Runtime.InteropServices;
using BibliotecaDotnet;
using BibliotecaDotnet.Modelos;
using BibliotecaDotnet.Modelos.Pessoas;

internal class Program
{
    static void Main(string[] args)
    {
        // GerenciadorDeBiblioteca gerenciador = new GerenciadorDeBiblioteca();
        // gerenciador.Iniciar();

        PessoaFisica cidadao = new PessoaFisica();
        PessoaJuridica empresa = new PessoaJuridica();

        cidadao.Id = 1;
        cidadao.Nome = "Leonardo";
        cidadao.NomeDaMae = "Mae do Leonardo";
        cidadao.MetodoPublico();

        empresa.Id = 2;
        empresa.Nome = "Empresa do Leonardo";
        empresa.NomeFantasia = "Fantasia";
        empresa.MetodoPublico();

    }
}