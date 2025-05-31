namespace Supermarket;

public class Cliente : Pessoa
{
    public Cliente(string cpf, string nome, string id)
    {
        this.Cpf = cpf;
        this.Nome = nome;
        this.Id = id;
    }

    public string Id { get; set; }
    public virtual double Desconto => 0.0; // somente leitura, impede a mudança de valores

    public void GetCliente()
    {
        Console.WriteLine($"ID: {this.Id}");
        Console.WriteLine($"NOME: {this.Nome}");
        Console.WriteLine($"CPF: {this.Cpf}");
        Console.WriteLine($"Desconto: {this.Desconto*100}%");
    }
}
