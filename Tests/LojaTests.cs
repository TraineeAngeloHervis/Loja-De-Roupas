using System.Text;
using Loja_De_Roupas.Models;
using Xunit;

namespace Loja_De_Roupas.tests;

public class LojaTests
{
    [Fact]
    public void DadoLoja_QuandoCadastroCliente_DeveIncrementarQuantidadeClientes()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var cliente1 = new Cliente
        {
            Nome = "Cliente 1",
            Email = "joao@gmail.com",
            Telefone = "999999999"
        };

        // Act
        loja.CadastrarCliente(cliente1);

        // Assert
        Assert.Equal(1, loja.ObterQuantidadeClientes());
    }

    [Fact]
    public void DadoLoja_QuandoRemoverCliente_DeveDecrementarQuantidadeClientes()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var cliente1 = new Cliente
        {
            Nome = "Cliente 1",
            Email = "joao@gmail.com",
            Telefone = "999999999"
        };
        loja.CadastrarCliente(cliente1);

        // Act
        loja.RemoverCliente(cliente1.Id);

        // Assert
        Assert.Equal(0, loja.ObterQuantidadeClientes());
    }


    [Fact]
    public void DadoLoja_QuandoListarInfosClientes_DeveExibirInfosClientes()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var cliente1 = new Cliente
        {
            Nome = "Cliente 1",
            Email = "joao@gmail.com",
            Telefone = "999999999"
        };
        var cliente2 = new Cliente
        {
            Nome = "Cliente 2",
            Email = "maria@gmail.com",
            Telefone = "999999999"
        };

        // Act
        loja.CadastrarCliente(cliente1);
        loja.CadastrarCliente(cliente2);
        var infosClientes = loja.ListarInfosClientes();
        var resultadoEsperado = ($"Nome: {cliente1.Nome}, " +
                                 $"Email: {cliente1.Email}, " +
                                 $"Telefone: {cliente1.Telefone}" +
                                 $"Nome: {cliente2.Nome}, " +
                                 $"Email: {cliente2.Email}, " +
                                 $"Telefone: {cliente2.Telefone}");
        
        // Assert
        Assert.Equal(resultadoEsperado, infosClientes);
    }

    [Fact]
    public void DadoLoja_QuandoCadastroRoupa_DeveIncrementarQuantidadeRoupas()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var roupa1 = new Roupa
        {
            Nome = "Camiseta",
            QuantidadePeca = 10,
            CategoriaPeca = "Vestuário",
            ValorPeca = 50
        };

        // Act
        loja.CadastrarRoupa(roupa1);

        // Assert
        Assert.Equal(1, loja.ObterQuantidadeRoupas());
    }

    [Fact]
    public void DadoLoja_QuandoRemoverRoupa_DeveDecrementarQuantidadeRoupas()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var roupa1 = new Roupa
        {
            Nome = "Camiseta",
            QuantidadePeca = 10,
            CategoriaPeca = "Vestuário",
            ValorPeca = 50
        };
        loja.CadastrarRoupa(roupa1);

        // Act
        loja.RemoverRoupa(roupa1.Id);

        // Assert
        Assert.Equal(0, loja.ObterQuantidadeRoupas());
    }

    [Fact]
    public void DadoLoja_QuandoListarInfosRoupas_DeveExibirInfosRoupas()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var roupa1 = new Roupa
        {
            Nome = "Camiseta",
            QuantidadePeca = 10,
            CategoriaPeca = "Vestuário",
            ValorPeca = 50
        };
        var roupa2 = new Roupa
        {
            Nome = "Calça",
            QuantidadePeca = 5,
            CategoriaPeca = "Vestuário",
            ValorPeca = 100
        };

        // Act
        loja.CadastrarRoupa(roupa1);
        loja.CadastrarRoupa(roupa2);
        var infosRoupas = loja.ListarInfosRoupas();
        var resultadoEsperado = ($"Nome: {roupa1.Nome}, " +
                                 $"Quantidade: {roupa1.QuantidadePeca}, " +
                                 $"Categoria: {roupa1.CategoriaPeca}, " +
                                 $"Valor: {roupa1.ValorPeca}" +
                                 $"Nome: {roupa2.Nome}, " +
                                 $"Quantidade: {roupa2.QuantidadePeca}, " +
                                 $"Categoria: {roupa2.CategoriaPeca}, " +
                                 $"Valor: {roupa2.ValorPeca}");

        // Assert
        Assert.Equal(resultadoEsperado, infosRoupas);
    }

    [Fact]
    public void DadoLoja_QuandoListarInfosLoja_DeveExibirInfosLoja()
    {
        // Arrange
        var loja = new Loja
        {
            Nome = "Loja 1"
        };
        var cliente1 = new Cliente
        {
            Nome = "Cliente 1",
            Email = "joao@gmail.com",
            Telefone = "999999999"
        };
        var cliente2 = new Cliente
        {
            Nome = "Cliente 2",
            Email = "maria@gmail.com",
            Telefone = "999999999"
        };
        var roupa1 = new Roupa
        {
            Nome = "Camiseta",
            QuantidadePeca = 10,
            CategoriaPeca = "Vestuário",
            ValorPeca = 50
        };
        var roupa2 = new Roupa
        {
            Nome = "Calça",
            QuantidadePeca = 5,
            CategoriaPeca = "Vestuário",
            ValorPeca = 100
        };

        // Act
        loja.CadastrarCliente(cliente1);
        loja.CadastrarCliente(cliente2);
        loja.CadastrarRoupa(roupa1);
        loja.CadastrarRoupa(roupa2);
        
        var infosLoja = loja.ListarInfosLoja();
        var resultadoEsperado = ($"Nome: {loja.Nome}, " +
                                 $"Total de roupas: {loja.ObterQuantidadeRoupas()}, " +
                                 $"Total de clientes: {loja.ObterQuantidadeClientes()}");
        
        // Assert
        Assert.Equal(resultadoEsperado, infosLoja);
    }
}