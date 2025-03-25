using System;

namespace BibliotecaDotnet.Modelos;

public class Livro
{
    public String Titulo { get; set; }

    public String Autor { get; set; }

    public int ISBN { get; set; }

    public DateTime DataDePublicacao { get; set; }

    public String Categoria { get; set; }

    public int Status { get; set; }
}
