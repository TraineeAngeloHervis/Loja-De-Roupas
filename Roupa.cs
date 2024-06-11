#nullable enable
namespace Loja_De_Roupas;

public class Roupa
{
    private static int _id = 1;
    public int Id { get; }
    public required string Nome { get; set; }
    public int QuantidadePeca { get; set; }
    public string? CategoriaPeca { get; set; }
    public decimal ValorPeca { get; set; }
    
public Roupa()
    {
        Id = _id++;
    }
}