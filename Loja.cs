using System.Text;

namespace Loja_De_Roupas;

public class Loja
{
    public Guid Id { get; }
    public string Nome { get; set; }
    private List<Cliente> Clientes { get; set; }
    private List<Roupa> Roupas { get; set; }
    
    public Loja()
    {
        Id = Guid.NewGuid();
        Clientes = new List<Cliente>();
        Roupas = new List<Roupa>();
    }
    
    public int ObterQuantidadeClientes()
    {
        return Clientes.Count;
    }

    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void RemoverCliente(Guid idCliente)
    {
        var cliente = Clientes.FirstOrDefault(c => c.Id == idCliente);
        if (cliente != null)
        {
            Clientes.Remove(cliente);
        }
    }

    public void CadastrarRoupa(Roupa roupa)
    {
        Roupas.Add(roupa);
    }
    
    public void RemoverRoupa(Guid idRoupa)
    {
        var roupa = Roupas.FirstOrDefault(r => Equals(r.Id, idRoupa));
        if (roupa != null)
        {
            Roupas.Remove(roupa);
        }
    }
    
    public string ListarInfosRoupas()
    {
        var infosRoupas = new StringBuilder();
        foreach (var roupa in Roupas)
        {
            infosRoupas.Append($"Nome: {roupa.Nome}, Quantidade: {roupa.QuantidadePeca}, Categoria: {roupa.CategoriaPeca}, Valor: {roupa.ValorPeca}");
        }
        return infosRoupas.ToString();
    }
    
    public int ObterQuantidadeRoupas()
    {
        return Roupas.Count;
    }
    
    public string ListarInfosClientes()
    {
        var infosClientes = new StringBuilder();
        foreach (var cliente in Clientes)
        {
           infosClientes.Append($"Nome: {cliente.Nome}, Email: {cliente.Email}, Telefone: {cliente.Telefone}");
        }

        return infosClientes.ToString();
    }
    
    public string ListarInfosLoja()
    {
        return $"Nome: {Nome}, Total de roupas: {ObterQuantidadeRoupas()}, Total de clientes: {ObterQuantidadeClientes()}";
    }
}