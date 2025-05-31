namespace Supermarket;

internal class Produto
{
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome { get; set; }
    public double Preco { get; set; }

    public void GetProduto()
    {
        Console.WriteLine($"{Nome}\t${Preco}");
    }
}
