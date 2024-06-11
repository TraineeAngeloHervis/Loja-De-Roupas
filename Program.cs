using Loja_De_Roupas;

var loja = new Loja
{
    Nome = "Minha Lojinha DB1",
    Clientes = [],
    Roupas = []
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

cliente.Carrinho.AdicionarRoupa(roupa);

carrinho.ListarInfosRoupas();

loja.ObterQuantidadeClientes();


Console.WriteLine("Loja: " + loja.Nome);
Console.WriteLine("Total de roupas: " + loja.Roupas.Count);
Console.WriteLine("Total de clientes: " + loja.Clientes.Count);

cliente.ObterInfosCliente();

Console.WriteLine("Roupa: " + roupa.Nome);
Console.WriteLine("Quantidade: " + roupa.QuantidadePeca);
Console.WriteLine("Categoria: " + roupa.CategoriaPeca);
Console.WriteLine("Valor: " + roupa.ValorPeca);

Console.WriteLine("Total de roupas no carrinho: " + cliente.Carrinho._roupas.Count);

Console.WriteLine(cliente.Carrinho.FinalizarPedido(cliente));

Console.WriteLine("Total de clientes: " + loja.ObterQuantidadeClientes());

Console.WriteLine("Total de clientes: " + loja.ObterQuantidadeClientes());