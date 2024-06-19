using Bogus;
using Loja_De_Roupas;

namespace Loja;

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
    
}