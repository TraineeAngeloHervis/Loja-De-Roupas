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
        var cliente = new ClienteBuilder().Novo().
        ComId(Guid.NewGuid()).
        ComNome("João").
        ComEmail("joao@gmail.com").
        ComTelefone("999999999").
        Build();

        // Act
        var infosCliente = cliente.ObterInfosCliente();

        // Assert
        //precisa terminar
    }
}