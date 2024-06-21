using Bogus;
using Loja_De_Roupas.Models;

namespace Loja_De_Roupas.Tests.Builders;

public class ClienteBuilder
{
    private readonly Faker<Cliente> _faker;

    public ClienteBuilder()
    {
        _faker = new Faker<Cliente>().CustomInstantiator(f => new Cliente()
        {
            Id = f.Random.Guid(),
            Nome = f.Person.FirstName,
            Email = f.Person.Email,
            Telefone = f.Person.Phone,
            Carrinho = new Carrinho()
        });
    }

    public static ClienteBuilder Novo()
        => new();

    public ClienteBuilder ComId(Guid id)
    {
        _faker.RuleFor(c => c.Id, id);
        return this;
    }

    public ClienteBuilder ComNome(string nome)
    {
        _faker.RuleFor(c => c.Nome, nome);
        return this;
    }

    public ClienteBuilder ComEmail(string email)
    {
        _faker.RuleFor(c => c.Email, email);
        return this;
    }

    public ClienteBuilder ComTelefone(string telefone)
    {
        _faker.RuleFor(c => c.Telefone, telefone);
        return this;
    }

    public ClienteBuilder ComCarrinho(Carrinho carrinho)
    {
        _faker.RuleFor(c => c.Carrinho, carrinho);
        return this;
    }

    public Cliente Build()
        => _faker.Generate();
}