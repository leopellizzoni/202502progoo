using System;

namespace ExemploComInterfaces;

//esses : equivalem ao implements do java
public class Gato : IAnimal
{
    public string EmitirSom()
    {
        return "Miau";
    }
}