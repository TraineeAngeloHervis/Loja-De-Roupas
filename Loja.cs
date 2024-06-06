namespace Loja_De_Roupas;

public class Loja
{
    public int Id { get; }
    public string Nome { get; set; }
    public int TotalClientes { get; set; }
    public List<Cliente> Clientes { get; set; }
    public List<Roupa> Roupas { get; set; }

    public Loja()
    {
        Clientes = new List<Cliente>();
        Roupas = new List<Roupa>();
    }

}