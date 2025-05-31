namespace Supermarket;

internal class Pagamento
{
    public Pagamento(Venda venda, FormaPagamento formaPagamento)
    {
        Venda = venda;
        FormaPagamento = formaPagamento;
    }

    public Venda Venda{ get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public double Total { get; set; }

    public void GerarNota()
    {
        Console.WriteLine("Dados do cliente");
        Venda.Cliente.GetCliente();

        Console.WriteLine($"FORMA DE PAGAMENTO: {FormaPagamento}");

        Console.WriteLine("PRODUTOS:");
        Console.WriteLine("NOME\tCUSTO");
        for (int i = 0; i < Venda.Produtos.Count(); i++)
        {
            Venda.Produtos[i].GetProduto();
            Total += Venda.Produtos[i].Preco;
        }

        Console.WriteLine($"Total a pagar: ${Total*(1-Venda.Cliente.Desconto):f2} reais");
    }
}
