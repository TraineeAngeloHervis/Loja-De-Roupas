using Loja_De_Roupas.Models;
using Bogus;

namespace Loja_De_Roupas.Tests.Builders;

public class RoupaBuilder
{
    private readonly Faker<Roupa> _faker;

    public RoupaBuilder()
    {
        _faker = new Faker<Roupa>().CustomInstantiator(f => new Roupa
        {
            Id = Guid.NewGuid(),
            Nome = f.Commerce.ProductName(),
            QuantidadePeca = f.Random.Number(1, 100),
            CategoriaPeca = f.Commerce.Categories(1)[0],
            ValorPeca = f.Random.Decimal(1, 1000)
        });
    }
    
    public static RoupaBuilder Novo()
        => new();

    public RoupaBuilder ComNome(string nome)
    {
        _faker.RuleFor(r => r.Nome, nome);
        return this;
    }
    
    public RoupaBuilder ComQuantidadePeca(int quantidadePeca)
    {
        _faker.RuleFor(r => r.QuantidadePeca, quantidadePeca);
        return this;
    }
    
    public RoupaBuilder ComCategoriaPeca(string categoriaPeca)
    {
        _faker.RuleFor(r => r.CategoriaPeca, categoriaPeca);
        return this;
    }
    
    public RoupaBuilder ComValorPeca(decimal valorPeca)
    {
        _faker.RuleFor(r => r.ValorPeca, valorPeca);
        return this;
    }
    
    public Roupa Build()
        => _faker.Generate();
}