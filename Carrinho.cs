namespace Loja_De_Roupas;

public class Carrinho
{
    public int IdCliente { get; set; }
    private List<Roupa> Roupas { get; set; }
    
    public Carrinho()
    {
        Roupas = new List<Roupa>();
    }

    public void AdicionarRoupa(Roupa roupa)
    {
        Roupas.Add(roupa);
    }

    public void RemoverRoupa(int idRoupa)
    {
        var roupa = Roupas.FirstOrDefault(r => r.Id == idRoupa);
        if (roupa != null)
        {
            Roupas.Remove(roupa);
        }
    }

    public void ListarInfosRoupas()
    {
        foreach (var roupa in Roupas)
        {
            Console.WriteLine($"Nome: {roupa.Nome}, Quantidade: {roupa.QuantidadePeca}, Categoria: {roupa.CategoriaPeca}, Valor: {roupa.ValorPeca}");
        }
    }

    public void FinalizarPedido()
    {
        decimal total = 0;

        foreach (var roupa in Roupas)
        {
            total += roupa.ValorPeca;
        }

        Console.WriteLine($"Total do pedido: {total}");

        Roupas.Clear();
    }
}
