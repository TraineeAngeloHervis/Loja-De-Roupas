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
        var loja = LojaBuilder.Novo().Build();
        var cliente = ClienteBuilder.Novo().Build();

        // Act
        loja.CadastrarCliente(cliente);

        // Assert
        Assert.Contains(cliente, loja.Clientes);
    }

    [Fact]
    public void DadoLoja_QuandoRemoverCliente_DeveRemoverCliente()
    {
        // Arrange
        var cliente = ClienteBuilder.Novo().Build();
        var loja = LojaBuilder.Novo().ComClientes([cliente]).Build();

        // Act
        loja.RemoverCliente(cliente.Id);

        // Assert
        Assert.DoesNotContain(cliente, loja.Clientes);
    }

    [Fact]
    public void DadoLoja_QuandoAdicionarRoupa_DeveAdicionarRoupa()
    {
        // Arrange
        var loja = LojaBuilder.Novo().Build();
        var roupa = RoupaBuilder.Novo().Build();

        // Act
        loja.CadastrarRoupa(roupa);

        // Assert
        Assert.Contains(roupa, loja.Roupas);
    }

    [Fact]
    public void DadoLoja_QuandoRemoverRoupa_DeveRemoverRoupa()
    {
        // Arrange
        var roupa = RoupaBuilder.Novo().Build();
        var loja = LojaBuilder.Novo().ComRoupas([roupa]).Build();

        // Act
        loja.RemoverRoupa(roupa.Id);

        // Assert
        Assert.DoesNotContain(roupa, loja.Roupas);
    }

    [Fact]
    public void DadoLoja_QuandoObterQuantidadeClientes_DeveRetornarQuantidadeClientes()
    {
        // Arrange
        var cliente = ClienteBuilder.Novo().Build();
        var loja = LojaBuilder.Novo().ComClientes([cliente]).Build();

        // Act
        var quantidadeClientes = loja.ObterQuantidadeClientes();
        const int resultadoEsperado = 1;

        // Assert
        Assert.Equal(resultadoEsperado, quantidadeClientes);
    }
}