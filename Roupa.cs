namespace Loja_De_Roupas;

public class Roupa
{
    public int Id { get;}
    public string Nome { get; set; }
    public int QuantidadePeca { get; set; }
    public string? CategoriaPeca { get; set; }
    public decimal ValorPeca { get; set; }
}