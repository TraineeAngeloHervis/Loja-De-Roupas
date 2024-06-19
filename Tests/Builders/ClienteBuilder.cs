using Bogus;


namespace Loja_De_Roupas.Tests.Builders;

public class ClienteBuilder
{
    private readonly Faker<Cliente> _faker;
    
    public ClienteBuilder()
    {
        _faker = new Faker<Cliente>().CustomInstantiator(f => new Cliente
            {
                Id = f.Random.Guid(),
                Nome = f.Person.FullName,
                Email = f.Person.Email,
                Telefone = f.Person.Phone,
                Carrinho = new Carrinho()
            });
    }
    
    public static ClienteBuilder Novo()
        => new();

    public ClienteBuilder ComNome(string nome)
    {
        _faker.RuleFor(c => c.Nome, f => nome);
        return this;
    }
    
    public ClienteBuilder ComEmail(string email)
    {
        _faker.RuleFor(c => c.Email, f => email);
        return this;
    }
    
    public ClienteBuilder ComTelefone(string telefone)
    {
        _faker.RuleFor(c => c.Telefone, f => telefone);
        return this;
    }
    
    public ClienteBuilder ComCarrinho(Carrinho carrinho)
    {
        _faker.RuleFor(c => c.Carrinho, f => carrinho);
        return this;
    }
    
    
    public Cliente Build()
        => _faker.Generate();
    
}