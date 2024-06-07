namespace Loja_De_Roupas;

public class Carrinho
{
    public int Id { get; }
    public int IdCliente { get; set; }
    public List<Roupa> Roupas { get; set; }

    public Carrinho()
    {
        Roupas = new List<Roupa>();
    }
}
