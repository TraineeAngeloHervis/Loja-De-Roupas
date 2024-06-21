using Loja_De_Roupas.Models;
using Loja_De_Roupas.Tests.Builders;
using Xunit;

namespace Loja_De_Roupas.Tests.Models;

public class CarrinhoTests
{
    [Fact]
    public void DadoCarrinho_QuandoAdicionarRoupa_DeveAdicionarRoupa()
    {
        // Arrange
        var carrinho = new Carrinho();
        var roupa = RoupaBuilder.Novo().Build();

        // Act
        carrinho.AdicionarRoupa(roupa);

        // Assert
        Assert.Contains(roupa, carrinho.Roupas);
    }

    [Fact]
    public void DadoCarrinho_QuandoRemoverRoupa_DeveRemoverRoupa()
    {
        // Arrange
        var roupa = RoupaBuilder.Novo().Build();
        var carrinho = new Carrinho();

        // Act
        carrinho.RemoverRoupa(roupa.Id);

        // Assert
        Assert.DoesNotContain(roupa, carrinho.Roupas);
    }

    [Fact]
    public void DadoCarrinho_QuandoFinalizarPedido_DeveRetornarMensagemPedidoFinalizado()
    {
        // Arrange
        var roupa = RoupaBuilder.Novo().ComValorPeca(100).Build();
        var carrinho = new Carrinho();
        var cliente = ClienteBuilder.Novo().Build();

        // Act
        carrinho.AdicionarRoupa(roupa);
        var mensagem = carrinho.FinalizarPedido(cliente);

        // Assert
        Assert.Equal("Pedido finalizado com sucesso! Total: 100", mensagem);
    }
}