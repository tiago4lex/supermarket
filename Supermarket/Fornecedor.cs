namespace Supermarket;

internal class Fornecedor
{
    public Fornecedor(string nome, string cnpj)
    {
        Nome = nome;
        Cnpj = cnpj;
    }

    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public List<Produto> Produtos{ get; set; }

    public void SetProdutos(List<Produto> produtos)
    {
        this.Produtos = produtos;
    }

    public void GetDados()
    {
        Console.WriteLine($"DADOS DO {this.GetType().Name}");
        Console.WriteLine($"NOME: {this.Nome}");
        Console.WriteLine($"CNPJ: {this.Cnpj}");
    }

    public void GetProdutos()
    {
        if (Produtos is null || Produtos.Count == 0)
        {
            Console.WriteLine("SEM PRODUTOS CADASTRADOS...");
            return;
        }
        Console.WriteLine("NOME\t$CUSTO");
        foreach (Produto produto in Produtos)
        {
            produto.GetProduto();
        }

    }
}
