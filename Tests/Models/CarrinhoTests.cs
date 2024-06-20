using Loja_De_Roupas.Models;
using Loja_De_Roupas.Tests.Builders;
using Xunit;

namespace Loja_De_Roupas.Tests.Models;

public class CarrinhoTests
{
    [Fact]
    public DadoCarrinho_QuandoAdicionarRoupa_DeveAdicionarRoupa()
    {
        // Arrange
        var carrinho = new CarrinhoBuilder().Novo().Build();
        var roupa = new RoupaBuilder().Novo().Build();

        // Act
        carrinho.AdicionarRoupa(roupa);

        // Assert
        Assert.Contains(roupa, carrinho.Roupas);
    }

    [Fact]
    public DadoCarrinho_QuandoRemoverRoupa_DeveRemoverRoupa()
    {
        // Arrange
        var roupa = new RoupaBuilder().Novo().Build();
        var carrinho = new CarrinhoBuilder().Novo().ComRoupas(new List<Roupa> { roupa }).Build();

        // Act
        carrinho.RemoverRoupa(roupa);

        // Assert
        Assert.DoesNotContain(roupa, carrinho.Roupas);
    }

    [Fact]
    public DadoCarrinho_QuandoFinalizarPedido_DeveRetornarMensagemPedidoFinalizado()
    {
        // Arrange
        var roupa = new RoupaBuilder().Novo().ComValorPeca(100).Build();
        var carrinho = new CarrinhoBuilder().Novo().ComRoupas(new List<Roupa> { roupa }).Build();
        var cliente = new ClienteBuilder().Novo().Build();

        // Act
        var mensagem = carrinho.FinalizarPedido(cliente);

        // Assert
        Assert.Equal("Pedido finalizado com sucesso! Total: 100", mensagem);
    }
}