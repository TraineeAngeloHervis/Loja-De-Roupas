#nullable enable
namespace Loja_De_Roupas;

public class Cliente
{
    private static int _id = 1;
    public int Id { get; private init; }
    public required string Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Carrinho Carrinho { get; set; }


    public Cliente()
    {
        Id = _id++;
        Carrinho = new Carrinho();
    }
    
    public void ObterInfosCliente()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}, Telefone: {Telefone}");
    }
}