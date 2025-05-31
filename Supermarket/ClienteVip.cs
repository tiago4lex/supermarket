namespace Supermarket;

public class ClienteVip : Cliente
{
    public ClienteVip(string cpf, string nome, string id)
        : base(cpf, nome, id) { } // esse codigo reutiliza o construtor base 

    public override double Desconto => 0.1; // 10% de desconto
}
