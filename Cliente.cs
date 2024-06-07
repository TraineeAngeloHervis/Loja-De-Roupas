#nullable enable
namespace Loja_De_Roupas;

public class Cliente
{
    private static int _id = 1;
    public int Id { get; }
    public required string Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Carrinho Carrinho { get; set; }


    public Cliente()
    {
        Id = _id++;
        Carrinho = new Carrinho();
    }

    public void ListarInfosRoupas()
    {
        Carrinho.ListarInfosRoupas();
    }

    public void FinalizarPedido()
    {
        Carrinho.FinalizarPedido();
    }

    public void ListarInfosCliente()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}, Telefone: {Telefone}");
    }
}