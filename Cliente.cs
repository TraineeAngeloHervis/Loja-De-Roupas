namespace Loja_De_Roupas;

public class Cliente
{
    public int Id { get; }
    public string Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    Carrinho Carrinho { get; set; }


    public Cliente()
    {
        Carrinho = new Carrinho();
    }

    public void AdicionarRoupa(Roupa roupa)
    {
        Carrinho.AdicionarRoupa(roupa);
    }

    public void RemoverRoupa(int idRoupa)
    {
        Carrinho.RemoverRoupa(idRoupa);
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