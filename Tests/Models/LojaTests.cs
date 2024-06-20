using Xunit;
using Loja_De_Roupas.Models;
using Loja_De_Roupas.Tests.Builders;

namespace Loja_De_Roupas.Tests.Models;

public class LojaTests
{
    [Fact]
    public void DadoLoja_QuandoAdicionarCliente_DeveAdicionarCliente()
    {
        // Arrange
        var loja = new LojaBuilder().Novo().Build();
        var cliente = new ClienteBuilder().Novo().Build();

        // Act
        loja.AdicionarCliente(cliente);

        // Assert
        Assert.Contains(cliente, loja.Clientes);
    }

    [Fact]
    public void DadoLoja_QuandoRemoverCliente_DeveRemoverCliente()
    {
        // Arrange
        var cliente = new ClienteBuilder().Novo().Build();
        var loja = new LojaBuilder().Novo().ComClientes(new List<Cliente> { cliente }).Build();

        // Act
        loja.RemoverCliente(cliente);

        // Assert
        Assert.DoesNotContain(cliente, loja.Clientes);
    }

    [Fact]
    public void DadoLoja_QuandoAdicionarRoupa_DeveAdicionarRoupa()
    {
        // Arrange
        var loja = new LojaBuilder().Novo().Build();
        var roupa = new RoupaBuilder().Novo().Build();

        // Act
        loja.AdicionarRoupa(roupa);

        // Assert
        Assert.Contains(roupa, loja.Roupas);
    }

    [Fact]
    public void DadoLoja_QuandoRemoverRoupa_DeveRemoverRoupa()
    {
        // Arrange
        var roupa = new RoupaBuilder().Novo().Build();
        var loja = new LojaBuilder().Novo().ComRoupas(new List<Roupa> { roupa }).Build();

        // Act
        loja.RemoverRoupa(roupa);

        // Assert
        Assert.DoesNotContain(roupa, loja.Roupas);
    }

    [Fact]
    public void DadoLoja_QuandoObterQuantidadeClientes_DeveRetornarQuantidadeClientes()
    {
        // Arrange
        var cliente = new ClienteBuilder().Novo().Build();
        var loja = new LojaBuilder().Novo().ComClientes(new List<Cliente> { cliente }).Build();

        // Act
        var quantidadeClientes = loja.ObterQuantidadeClientes();

        // Assert
        Assert.Equal(1, quantidadeClientes);
    }
}