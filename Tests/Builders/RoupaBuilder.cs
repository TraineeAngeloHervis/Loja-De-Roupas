namespace Loja_De_Roupas.Tests.Builders;

public class RoupaBuilder
{
    private string _nome = "Camiseta";
    private int _quantidadePeca = 10;
    private string _categoriaPeca = "Vestuário";
    private decimal _valorPeca = 50;

    public Roupa Build()
    {
        return new Roupa
        {
            Nome = _nome,
            QuantidadePeca = _quantidadePeca,
            CategoriaPeca = _categoriaPeca,
            ValorPeca = _valorPeca
        };
    }

    public RoupaBuilder ComNome(string nome)
    {
        _nome = nome;
        return this;
    }

    public RoupaBuilder ComQuantidadePeca(int quantidadePeca)
    {
        _quantidadePeca = quantidadePeca;
        return this;
    }

    public RoupaBuilder ComCategoriaPeca(string categoriaPeca)
    {
        _categoriaPeca = categoriaPeca;
        return this;
    }

    public RoupaBuilder ComValorPeca(decimal valorPeca)
    {
        _valorPeca = valorPeca;
        return this;
    }
}