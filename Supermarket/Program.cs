using Supermarket;
using System.Data;


//classes do processo de pagamento no geral
// populando funcionarios
var cliente = new Cliente("123465789", "jarvan IV", "1");
var vip = new ClienteVip("987564321", "gragas", "2");
var funcionario1 = new Funcionario("654987321", "master yi", "3", 1400.00);
var funcionario2 = new Funcionario("857483912", "Lux", "4", 1400.00); // vai ser usada na hora de dar o get funcionario la na frente
var clienteFuncionario = new ClienteFuncionario(funcionario1);







funcionario1.GetFuncionario();
Console.WriteLine("\n");
cliente.GetCliente();
Console.WriteLine("\n");
vip.GetCliente();
Console.WriteLine("\n");
clienteFuncionario.GetCliente();
Console.WriteLine("\n");



Console.ReadKey();
Console.Clear();



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

var novaVenda3 = new Venda(clienteFuncionario, listaProdutos);
var novoPagamento3 = new Pagamento(novaVenda3, FormaPagamento.Cedulas);
novoPagamento3.GerarNota();





Console.ReadKey();
Console.Clear();





//classes do supermercado
var supermercado = new Supermercado("Codeteck Atacarejo", "123465798", "36982147");
// parte dos funcionarios
var listaFuncionarios = new List<Funcionario>() {funcionario1, funcionario2};
supermercado.SetFuncionarios(listaFuncionarios);
supermercado.GetFuncionarios();


Console.ReadKey();
Console.Clear();


// parte dos fornecedores
var fornecedor1 = new Fornecedor("LinkPark Camarões", "123456789");
var fornecedor2 = new Fornecedor("Carrapeta para Caminhões SA", "3698487502");
var listaFornecedores = new List<Fornecedor>() { fornecedor1, fornecedor2 };
supermercado.SetFornecedores(listaFornecedores);
supermercado.GetFornecedores();

fornecedor2.GetProdutos();
Console.WriteLine("\n");

fornecedor1.SetProdutos(listaProdutos);
fornecedor1.GetProdutos();

Console.ReadKey();

