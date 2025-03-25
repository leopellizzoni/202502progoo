using System;

namespace BibliotecaDotnet.Modelos;

public class Usuario
{   
    public Usuario(int id, String nome, String email, String whatsApp)
    {
        Id = id;
        Nome = nome;
        Email = email;
        WhatsApp = whatsApp;
    }

    public int Id {get;set;}

    public String Nome {get;set;}

    public String Email { get; set; }

    public String WhatsApp {get;set;}

    //Lista de livros... TO DO
    
}
