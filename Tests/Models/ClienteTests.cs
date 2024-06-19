#nullable enable
namespace Loja_De_Roupas;

public class ClienteTests
{
    public Guid Id { get; }
    public required string Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Carrinho Carrinho { get; set; }

    public ClienteTests()
    {
        Id = Guid.NewGuid();
        Carrinho = new Carrinho();
    }
    
    public void ObterInfosCliente()
    {
        Console.WriteLine($"ID: {Id}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}");
    }
}