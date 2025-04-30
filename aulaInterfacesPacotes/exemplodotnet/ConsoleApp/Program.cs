//equivale ao import do java ou include do c
using ExemploComInterfaces; 

IBemVindo bemVindo;
String opcaoIdioma;

Console.WriteLine("Digite A para Portugues ou B para Ingles: ");
opcaoIdioma = Console.ReadLine();

if (opcaoIdioma == "A")
{
    bemVindo = new BemVindoPortugues();
}
else if (opcaoIdioma == "B")
{
    bemVindo = new BemVindoIngles();
}
else 
{
    bemVindo = new BemVindoNaoInformado();
}

//Nesse ponto aqui nos sabemos qual vai ser a classe instanciada... sabemos que tem uma 
//mas nao sabemos qual... 
Console.WriteLine(bemVindo.ObterMensagem());

IAnimal cachorro = new Cachorro();
IAnimal gato = new Gato();
//IAnimal vaca = new Vaca(); //Nao permite pois a classe vaca nao implementa a intereface IAniaml. Só funciona se houver os : IAnimal

Vaca vacaQueFunciona = new Vaca();
vacaQueFunciona.EmitirSom();


Console.WriteLine(cachorro.EmitirSom()); //Espero que o retorno seja Au au 
Console.WriteLine(gato.EmitirSom()); //Espero que o retorno seja Miau
