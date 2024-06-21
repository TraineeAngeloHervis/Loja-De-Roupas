namespace Loja_De_Roupas.Models;

public class Carrinho
{
    public Guid IdCliente { get; init; }
    public List<Roupa> _roupas;
    
    public Carrinho()
    {
        _roupas = [];
    }

    public void AdicionarRoupa(Roupa roupa)
    {
        _roupas.Add(roupa);
    }

    public void RemoverRoupa(Guid idRoupa)
    {
        var roupa = _roupas.FirstOrDefault(r => r.Id == idRoupa);
        if (roupa != null)
        {
            _roupas.Remove(roupa);
        }
    }

    public void ListarInfosRoupas()
    {
        foreach (var roupa in _roupas)
        {
            Console.WriteLine($"Nome: {roupa.Nome}, Quantidade: {roupa.QuantidadePeca}, Categoria: {roupa.CategoriaPeca}, Valor: {roupa.ValorPeca}");
        }
    }
    
    public string FinalizarPedido(Cliente cliente)
    {
        var total = _roupas.Sum(r => r.ValorPeca);
        return $"Pedido finalizado com sucesso! Total: {total}";
    }
}