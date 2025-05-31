namespace Supermarket;

internal class Venda
{
    public Venda(Cliente cliente, List<Produto> produtos)
    {
        Cliente = cliente;
        Produtos = produtos;
    }

    public Cliente Cliente { get; set; }
    public List<Produto> Produtos{ get; set; }
}
