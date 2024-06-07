using Loja_De_Roupas;

var loja = new Loja
{
    Nome = "Minha Lojinha DB1",
    TotalClientes = 0,
    Clientes = null,
    Roupas = null
};
var cliente = new Cliente
{
    Nome = "João",
    Email = "joao@gmail.com",
    Telefone = "999999999"
};
var roupa = new Roupa
{
    Nome = "Camiseta",
    QuantidadePeca = 10,
    CategoriaPeca = "Vestuário",
    ValorPeca = 50
};

var carrinho = new Carrinho();

loja.CadastrarRoupa(roupa);

loja.CadastrarCliente(cliente);

cliente.ObterInfosCliente();

cliente.Carrinho.AdicionarRoupa(roupa);

carrinho.ListarInfosRoupas();

cliente.Carrinho.FinalizarPedido();

loja.RemoverRoupa(roupa.Id);

loja.ObterQuantidadeClientes();

loja.RemoverCliente(cliente.Id);

loja.ObterQuantidadeClientes();
