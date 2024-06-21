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
    
    [Fact]
    public void DadoCarrinho_QuandoListarInfosRoupas_DeveRetornarInfosRoupas()
    {
        // Arrange
        var roupa = RoupaBuilder.Novo().Build();
        var carrinho = new Carrinho();
        carrinho.AdicionarRoupa(roupa);

        // Act
        var infosRoupas = carrinho.ListarInfosRoupas();

        // Assert
        Assert.Equal($"Nome: {roupa.Nome}, Quantidade: {roupa.QuantidadePeca}, Categoria: {roupa.CategoriaPeca}, Valor: {roupa.ValorPeca}", infosRoupas);
    }
    
    [Fact]
    public void DadoCarrinho_QuandoObterQuantidadeRoupas_DeveRetornarQuantidadeRoupas()
    {
        // Arrange
        var roupa = RoupaBuilder.Novo().Build();
        var carrinho = new Carrinho();
        carrinho.AdicionarRoupa(roupa);

        // Act
        var quantidadeRoupas = carrinho.ObterQuantidadeRoupas();
        const int resultadoEsperado = 1;

        // Assert
        Assert.Equal(resultadoEsperado, quantidadeRoupas);
    }
}