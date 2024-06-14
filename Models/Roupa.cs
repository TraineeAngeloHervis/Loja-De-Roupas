namespace Loja_De_Roupas.Models;

public class Roupa
{
    public Guid Id { get; } = Guid.NewGuid();
    public required string Nome { get; set; }
    public int QuantidadePeca { get; set; }
    public string? CategoriaPeca { get; set; }
    public decimal ValorPeca { get; set; }
}