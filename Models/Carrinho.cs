namespace Loja_De_Roupas.Models;

public class Carrinho
{
    public Guid IdCliente { get; init; }
    public List<Roupa> Roupas;

    public Carrinho()
    {
        Roupas = [];
    }

    public void AdicionarRoupa(Roupa roupa)
    {
        Roupas.Add(roupa);
    }

    public void RemoverRoupa(Guid idRoupa)
    {
        var roupa = Roupas.FirstOrDefault(r => r.Id == idRoupa);
        if (roupa != null)
        {
            Roupas.Remove(roupa);
        }
    }

    public string ListarInfosRoupas()
    {
        var infosRoupas = "";
        foreach (var roupa in Roupas)
        {
            infosRoupas =
                ($"Nome: {roupa.Nome}, Quantidade: {roupa.QuantidadePeca}, Categoria: {roupa.CategoriaPeca}, Valor: {roupa.ValorPeca}");
        }

        return infosRoupas;
    }

    public string FinalizarPedido(Cliente cliente)
    {
        var total = Roupas.Sum(r => r.ValorPeca);
        return $"Pedido finalizado com sucesso! Total: {total}";
    }
    
    public int ObterQuantidadeRoupas()
    {
        return Roupas.Count;
    }
}