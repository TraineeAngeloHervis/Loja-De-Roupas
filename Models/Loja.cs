﻿namespace Loja_De_Roupas.Models;

public class Loja
{
    public Guid Id { get; init; }
    public string Nome { get; set; }
    public List<Cliente> Clientes { get; set; }
    public List<Roupa> Roupas { get; set; }

    public int ObterQuantidadeClientes()
    {
        return Clientes.Count;
    }

    public int ObterQuantidadeRoupas()
    {
        return Roupas.Count;
    }

    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void RemoverCliente(Guid idCliente)
    {
        var cliente = Clientes.FirstOrDefault(c => c.Id == idCliente);
        if (cliente != null)
        {
            Clientes.Remove(cliente);
        }
    }

    public void CadastrarRoupa(Roupa roupa)
    {
        Roupas.Add(roupa);
    }

    public void RemoverRoupa(Guid idRoupa)
    {
        var roupa = Roupas.FirstOrDefault(r => Equals(r.Id, idRoupa));
        if (roupa != null)
        {
            Roupas.Remove(roupa);
        }
    }

    public string ListarInfosRoupas()
    {
        var infosRoupas = "";
        foreach (var roupa in Roupas)
        {
            infosRoupas =
                ($"Nome: {roupa.Nome}, Quantidade: {roupa.QuantidadePeca}, Categoria: {roupa.CategoriaPeca}, Valor: {roupa.ValorPeca}");
        }

        return infosRoupas;
    }

    public string ListarInfosClientes()
    {
        var infosClientes = "";
        foreach (var cliente in Clientes)
        {
            infosClientes =
                ($"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}, Telefone: {cliente.Telefone}");
        }

        return infosClientes;
    }

    public string ListarInfosLoja()
    {
        return (
            $"ID: {Id}, Nome: {Nome}, Quantidade de Clientes: {Clientes.Count}, Quantidade de Roupas: {Roupas.Count}");
    }
}