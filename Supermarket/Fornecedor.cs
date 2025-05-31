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

    public void SetProdutos()
    {

    }

    public void GetDados()
    {

    }
}
