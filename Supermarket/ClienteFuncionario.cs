namespace Supermarket;

internal class ClienteFuncionario : Cliente
{
    public ClienteFuncionario(string cpf, string nome, string id)
        : base (cpf, nome, id) { } // reciclando construtor do Cliente

    public override double Desconto => 0.15; // 15% de desconto
}
