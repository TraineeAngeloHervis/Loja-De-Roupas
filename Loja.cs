namespace Loja_De_Roupas;

public class Loja
{
    private static int _id = 1;
    public int Id { get; private init; }
    public string Nome { get; set; }
    public int TotalClientes { get; set; }
    public List<Cliente> Clientes { get; set; }
    public List<Roupa> Roupas { get; set; }

    public Loja()
    {
        Id = _id++;
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

    public void RemoverCliente(int idCliente)
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

    public void RemoverRoupa(int idRoupa)
    {
        var roupa = Roupas.FirstOrDefault(r => r.Id == idRoupa);
        if (roupa != null)
        {
            Roupas.Remove(roupa);
        }
    }
}