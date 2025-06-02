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
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine($"NOME: {this.Nome}");
        Console.WriteLine($"CNPJ: {this.Cnpj}");
        Console.WriteLine($"CEP: {this.Cep}");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-\n");

    }

    public void GetFuncionarios()
    {
        Console.WriteLine("FUNCIONARIOS:");
        if(Funcionarios is null || Funcionarios.Count == 0) // se não tiver feito o set antes vai cair nesse if
        {
            Console.WriteLine("NENHUM FUNCIONARIO CADASTRADO...");
            return;
        }
        foreach(Funcionario funcionario in this.Funcionarios)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            funcionario.GetFuncionario();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-\n");
        }
    }

    public void GetFornecedores()
    {
        Console.WriteLine("Fornecedores:");
        if (Fornecedores is null || Fornecedores.Count == 0) // se não tiver feito o set antes vai cair nesse if
        {
            Console.WriteLine("NENHUM FORNECEDOR CADASTRADO...");
            return;
        }
        foreach (Fornecedor fornecedor in this.Fornecedores)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            fornecedor.GetDados();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-\n");
        }
    }
}
