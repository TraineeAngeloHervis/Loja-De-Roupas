using Bogus;
using Loja_De_Roupas.Models;

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
        _faker.RuleFor(l => l.Nome, nome);
        return this;
    }

    public LojaBuilder ComClientes(List<Cliente> clientes)
    {
        _faker.RuleFor(l => l.Clientes, clientes);
        return this;
    }

    public LojaBuilder ComRoupas(List<Roupa> roupas)
    {
        _faker.RuleFor(l => l.Roupas, roupas);
        return this;
    }
    
    public Loja Build()
        => _faker.Generate();
}