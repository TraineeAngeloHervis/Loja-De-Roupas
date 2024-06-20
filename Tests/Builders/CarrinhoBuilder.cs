using Bogus;
using Loja_De_Roupas.Models;

namespace Loja_De_Roupas.Tests.Builders;

public class CarrinhoBuilder
{
    private readonly Faker<Carrinho> _faker;
    
    public CarrinhoBuilder()
    {
        _faker = new Faker<Carrinho>().CustomInstantiator(f => new Carrinho
            {
                IdCliente = f.Random.Guid(),
                _roupas = []
            });
    }
    
    public static CarrinhoBuilder Novo()
        => new();

    public CarrinhoBuilder ComIdCliente(Guid idCliente)
    {
        _faker.RuleFor(c => c.IdCliente, f => idCliente);
        return this;
    }
    
    public CarrinhoBuilder ComRoupas(List<Roupa> roupas)
    {
        _faker.RuleFor(c => c._roupas, f => roupas);
        return this;
    }
    
    public Carrinho Build()
        => _faker.Generate();
    
}