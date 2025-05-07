using System.Security.Cryptography;

namespace TratamentoPIX;

public class GerenciadorDoPIX
{
    public GerenciadorDoPIX(double saldo, double limite)
    {
        Saldo = saldo;
        Limite = limite;
    }

    private double Saldo { get; set; }

    private double Limite { get; set; }

    public bool Transferir(double valor)
    {
        if (valor > Limite)
        {
            throw new Exception($"Não podemos fazer o pix por causa do limite de {Limite} excedido");
        }

        if (valor > Saldo)
        {
            throw new Exception("Saldo insuficiente");
        }

        return true;
    }
}
