namespace Supermarket;

public class Funcionario : Pessoa
{
    public Funcionario(string Cpf, string Nome, string id, double salario)
    {
        this.Cpf = Cpf;
        this.Nome = Nome;
        this.Id = id;
        this.Salario = salario;
    }

    public string Id { get; set; }
    public double Salario { get; set; }

    public void GetFuncionario()
    {
        Console.WriteLine($"ID: {this.Id}");
        Console.WriteLine($"NOME: {this.Nome}");
        Console.WriteLine($"CPF: {this.Cpf}");
        Console.WriteLine($"SALARIO: {this.Salario}");
    }
}
