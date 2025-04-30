using System;

namespace ExemploComInterfaces;

//esses : equivalem ao implements do java
public class Cachorro : IAnimal
{
    public string EmitirSom()
    {
        return "Au au";
    }
}