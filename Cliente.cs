namespace Loja_De_Roupas;

public class Cliente
{
    public Guid Id { get; }
    public required string Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Carrinho Carrinho { get; set; }

    public Cliente()
    {
        Id = Guid.NewGuid();
        Carrinho = new Carrinho();
    }
    
    public string ObterInfosCliente()
    {
        var infosCliente = $"ID: {Id}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}";
        return infosCliente;
    }
}