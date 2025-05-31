using Supermarket;

var cliente = new Cliente("123465789", "jarvan IV", "1");
var vip = new ClienteVip("987564321", "gragas", "2");
var funcionario = new Funcionario("654987321", "master yi", "3", 1400.00);
var clienteFuncionario = new ClienteFuncionario("2430598781", "yumi", "4");

funcionario.GetFuncionario();
Console.WriteLine("\n");
cliente.GetCliente();
Console.WriteLine("\n");
vip.GetCliente();
Console.WriteLine("\n");
clienteFuncionario.GetCliente();
Console.WriteLine("\n");

List<Produto> listaProdutos = new List<Produto>() 
{
    new Produto("maçã", 2.33),
    new Produto("pera", 3.56)
};

var novaVenda1 = new Venda(cliente, listaProdutos);
var novoPagamento1 = new Pagamento(novaVenda1, FormaPagamento.Credito);
novoPagamento1.GerarNota();

var novaVenda2 = new Venda(vip, listaProdutos);
var novoPagamento2 = new Pagamento(novaVenda2, FormaPagamento.Debito);
novoPagamento2.GerarNota();
