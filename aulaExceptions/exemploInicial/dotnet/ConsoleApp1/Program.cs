using TratamentoPIX;

Console.WriteLine("Hello, World!");

GerenciadorDoPIX gerPix = new GerenciadorDoPIX(10000, 900);

try
{
    System.Console.WriteLine("Transferencia dos 10");
    System.Console.WriteLine(gerPix.Transferir(10));
    System.Console.WriteLine("Transferencia dos 90000");
    System.Console.WriteLine(gerPix.Transferir(90000)); //linha que gera o erro
    //daqui em para baixo nao executa mais nada DENTRO desse try
    Console.WriteLine("Processamentos feitos com sucesso");
}
catch (Exception variavelEx)
{
    //apenas quando gera erro
    Console.WriteLine("========================== ERRO");
    Console.WriteLine(variavelEx.Message);
}
finally
{
    //sempre executa
    Console.WriteLine("Executou o Finally");
}

Console.WriteLine("THE END");