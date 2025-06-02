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
        Console.WriteLine("\n\n-=-=-=-=-=-=-=| GERANDO NOTA |=-=-=--=-=-=-=-=-");
        Venda.Cliente.GetCliente();

        Console.WriteLine($"\nFORMA DE PAGAMENTO: {FormaPagamento}");

        Console.WriteLine("PRODUTOS:");
        Console.WriteLine("NOME\tCUSTO");
        for (int i = 0; i < Venda.Produtos.Count(); i++)
        {
            Venda.Produtos[i].GetProduto();
            Total += Venda.Produtos[i].Preco;
        }

        Console.WriteLine($"\nTotal a pagar: ${Total*(1-Venda.Cliente.Desconto):f2} reais");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

    }
}
