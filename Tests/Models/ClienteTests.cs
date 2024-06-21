using System;
using Xunit;
using Loja_De_Roupas.Models;
using Loja_De_Roupas.Tests.Builders;

namespace Loja_De_Roupas.Tests.Models;

public class ClienteTests
{
    [Fact]
    public void DadoCliente_QuandoObterInfosCliente_DeveRetornarInfosCliente()
    {
        // Arrange
        var cliente = ClienteBuilder.Novo().Build();

        // Act
        var infosCliente = cliente.ObterInfosCliente();

        // Assert
        var resultadoEsperado = $"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}, Telefone: {cliente.Telefone}";
        Assert.Equal(resultadoEsperado, infosCliente);
    }
}