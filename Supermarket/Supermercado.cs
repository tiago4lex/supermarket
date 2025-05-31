namespace Supermarket;

internal class Supermercado
{
    public Supermercado(string nome, string cnpj, string cep)
    {
        Nome = nome;
        Cnpj = cnpj;
        Cep = cep;
    }

    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string Cep { get; set; }
    public List<Fornecedor> Fornecedores { get; set; }
    public List<Funcionario> Funcionarios{ get; set; }


    public void SetFornecedores(List<Fornecedor> fornecedores)
    {
        this.Fornecedores = fornecedores;
    }

    public void SetFuncionarios(List<Funcionario> funcionarios)
    {
        this.Funcionarios = funcionarios;
    }

    public void GetDados()
    {
        Console.WriteLine($"NOME: {this.Nome}");
        Console.WriteLine($"CNPJ: {this.Cnpj}");
        Console.WriteLine($"CEP: {this.Cep}");
    }
}
