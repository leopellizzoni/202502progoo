using System;

namespace BibliotecaDotnet.Modelos.Pessoas;

public class Pessoa : ObjetoComId
{
    public Pessoa()
    {
        MetodoPrivado();
    }

    public String Nome {get;set;} 

    //Aparece para todas as variavies instanciadas
    public String MetodoPublico()
    {
        return "";
    }
    
    //acessado da propria classe e das classes filhas.
    //Classe filha é quem herda de uma outra classe
    protected String MetodoProtected()
    {
        return "";
    }

    //uso especifico da classe atual. nenhum outro permite acesso.
    private String MetodoPrivado()
    {
        return "Gerada na classe pai de pessoa: " + Nome;
    }
}

//Versao Java public class PessoaFisica extends Pessoa
//PessoaFisica possui uma herança (:) para a classe pessoa
public class PessoaFisica : Pessoa
{
    public PessoaFisica()
    {
        MetodoProtected();
    }
    public String CPF {get;set;}

     public String NomeDaMae {get;set;}

    public String NomeDoPai {get;set;}
}

//Versao Java public class PessoaJuridica extends Pessoa
public class PessoaJuridica : Pessoa
{
    public String CNPJ {get;set;}

    public String NomeFantasia {get;set;}
}
