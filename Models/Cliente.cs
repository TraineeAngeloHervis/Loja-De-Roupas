namespace Loja_De_Roupas.Models;

public class Cliente
{
    public Guid Id { get; init; }
    public required string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Carrinho Carrinho { get; set; }

    public Cliente()
    {
        Id = Guid.NewGuid();
        Carrinho = new Carrinho();
    }

    public string ObterInfosCliente()
    {
        return ($"ID: {Id}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}");
    }
}