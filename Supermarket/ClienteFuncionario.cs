namespace Supermarket;

internal class ClienteFuncionario : Cliente
{
    public ClienteFuncionario(Funcionario funcionario) : base(funcionario.Cpf, funcionario.Nome, funcionario.Id) // reciclando construtor do Cliente
    {
        this.Funcionario = funcionario;
        this.Cpf = this.Funcionario.Cpf;
        this.Nome = this.Funcionario.Nome;
        this.Id = Funcionario.Id;
    }

    public override double Desconto => 0.15; // 15% de desconto
    public Funcionario Funcionario { get; set; }

    public override void GetCliente() // sobreescrevendo o codigo para mostrar os detalhes do funcionario e o desconto
    {
        Funcionario.GetFuncionario();
        Console.WriteLine($"Desconto: {this.Desconto * 100}%");
    }
}