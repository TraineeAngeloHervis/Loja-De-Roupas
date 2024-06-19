using Bogus;

namespace Loja_De_Roupas.Tests.Builders;

public class LojaBuilder
{
    private readonly Faker<Loja> _faker;
    private List<Cliente> _clientes = [];
    private List<Roupa> _roupas = [];

    public LojaBuilder()
    {
        _faker = new Faker<Loja>().CustomInstantiator(f => new Loja()
        {
            Id = Guid.NewGuid(),
            Nome = f.Company.CompanyName(),
            Clientes = [],
            Roupas = []
        });
    }

    public static LojaBuilder Novo()
        => new();

    public LojaBuilder ComNome(string nome)
    {
        _faker.RuleFor(l => l.Nome, f => nome);
        return this;
    }

    public LojaBuilder ComClientes(List<Cliente> clientes)
    {
        _faker.RuleFor(l => l.Clientes, f => clientes);
        return this;
    }

    public LojaBuilder ComRoupas(List<Roupa> roupas)
    {
        _faker.RuleFor(l => l.Roupas, f => roupas);
        return this;
    }

    public int ObterQuantidadeClientes()
    {
        return _clientes.Count;
    }

    public LojaBuilder CadastrarCliente(Cliente cliente)
    {
        _clientes.Add(cliente);
        return this;
    }

    public LojaBuilder RemoverCliente(Guid idCliente)
    {
        var cliente = _clientes.FirstOrDefault(c => c.Id == idCliente);
        if (cliente != null)
        {
            _clientes.Remove(cliente);
        }

        return this;
    }

    public LojaBuilder CadastrarRoupa(Roupa roupa)
    {
        _roupas.Add(roupa);
        return this;
    }

    public LojaBuilder RemoverRoupa(Guid idRoupa)
    {
        var roupa = _roupas.FirstOrDefault(r => Equals(r.Id, idRoupa));
        if (roupa != null)
        {
            _roupas.Remove(roupa);
        }

        return this;
    }
}