using Loja_De_Roupas;
using Loja_De_Roupas.Models;

var loja = new Loja
{
    Nome = "Minha Lojinha DB1",
};

var cliente1 = new Cliente
{
    Nome = "João",
    Email = "joao@gmail.com",
    Telefone = "999999999"
};

var cliente2 = new Cliente
{
    Nome = "Maria",
    Email = "maria@gmail.com",
    Telefone = "888888888"
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

var carrinho = new Carrinho();

loja.CadastrarCliente(cliente1);
loja.CadastrarCliente(cliente2);
loja.CadastrarRoupa(roupa1);
loja.CadastrarRoupa(roupa2);
loja.RemoverRoupa(roupa1.Id);
loja.RemoverCliente(cliente1.Id);
loja.CadastrarCliente(cliente1);
loja.CadastrarRoupa(roupa1);
loja.ListarInfosClientes();
loja.ListarInfosRoupas();
loja.ObterQuantidadeClientes();
loja.ObterQuantidadeRoupas();
loja.ListarInfosRoupas();
loja.ListarInfosLoja();

carrinho.AdicionarRoupa(roupa1);
carrinho.AdicionarRoupa(roupa2);
carrinho.ListarInfosRoupas();
carrinho.ObterQuantidadeRoupas();
carrinho.RemoverRoupa(roupa2.Id);
carrinho.FinalizarPedido(cliente1);

cliente1.ObterInfosCliente();
cliente2.ObterInfosCliente();

Console.WriteLine("FIM DO PROGRAMA!");