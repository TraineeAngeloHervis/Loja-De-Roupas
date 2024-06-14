using Loja_De_Roupas.Models;
using Xunit;

namespace Loja_De_Roupas.tests;

public class ClienteTests
{
    [Fact]
    public void DadoClienteComInfos_QuandoObterInfosCliente_DeveRetornarInfosCorretas()
    {
        // Arrange
        var cliente = new Cliente
        {
            Nome = "Cliente 1",
            Email = "joao#gmail.com",
            Telefone = "999999999"
        };
        
        // Act
        var infosCliente = cliente.ObterInfosCliente();
        var resultadoEsperado = $"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}, Telefone: {cliente.Telefone}";
        
        // Assert
        Assert.Equal(resultadoEsperado, infosCliente);
    }
}