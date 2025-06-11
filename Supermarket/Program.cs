using Supermarket;
using System.Data;


////classes do processo de pagamento no geral
//// populando funcionarios
//var cliente = new Cliente("123465789", "jarvan IV", "1");
//var vip = new ClienteVip("987564321", "gragas", "2");
//var funcionario1 = new Funcionario("654987321", "master yi", "3", 1400.00);
//var funcionario2 = new Funcionario("857483912", "Lux", "4", 1400.00); // vai ser usada na hora de dar o get funcionario la na frente
//var clienteFuncionario = new ClienteFuncionario(funcionario1);

//funcionario1.GetFuncionario();
//Console.WriteLine("\n");
//cliente.GetCliente();
//Console.WriteLine("\n");
//vip.GetCliente();
//Console.WriteLine("\n");
//clienteFuncionario.GetCliente();
//Console.WriteLine("\n");

//Console.ReadKey();
//Console.Clear();

//List<Produto> listaProdutos = new List<Produto>() 
//{
//    new Produto("maçã", 2.33),
//    new Produto("pera", 3.56)
//};

//var novaVenda1 = new Venda(cliente, listaProdutos);
//var novoPagamento1 = new Pagamento(novaVenda1, FormaPagamento.Credito);
//novoPagamento1.GerarNota();

//var novaVenda2 = new Venda(vip, listaProdutos);
//var novoPagamento2 = new Pagamento(novaVenda2, FormaPagamento.Debito);
//novoPagamento2.GerarNota();

//var novaVenda3 = new Venda(clienteFuncionario, listaProdutos);
//var novoPagamento3 = new Pagamento(novaVenda3, FormaPagamento.Cedulas);
//novoPagamento3.GerarNota();

//Console.ReadKey();
//Console.Clear();

////classes do supermercado
//var supermercado = new Supermercado("Codeteck Atacarejo", "123465798", "36982147");
//// parte dos funcionarios
//var listaFuncionarios = new List<Funcionario>() {funcionario1, funcionario2};
//supermercado.SetFuncionarios(listaFuncionarios);
//supermercado.GetFuncionarios();

//Console.ReadKey();
//Console.Clear();

//// parte dos fornecedores
//var fornecedor1 = new Fornecedor("LinkPark Camarões", "123456789");
//var fornecedor2 = new Fornecedor("Carrapeta para Caminhões SA", "3698487502");
//var listaFornecedores = new List<Fornecedor>() { fornecedor1, fornecedor2 };
//supermercado.SetFornecedores(listaFornecedores);
//supermercado.GetFornecedores();

//fornecedor2.GetProdutos();
//Console.WriteLine("\n");

//fornecedor1.SetProdutos(listaProdutos);
//fornecedor1.GetProdutos();

//Console.ReadKey();


// populando com dados iniciais
List<Cliente> listaClientes = new List<Cliente>();
List<Fornecedor> listaFornecedores = new List<Fornecedor>();
List<Funcionario> listaFuncionarios = new List<Funcionario>();

var funcionario1 = new Funcionario("654987321", "Master Yi", "3", 1400.00);
var funcionario2 = new Funcionario("857483912", "Lux", "4", 1400.00);
listaFuncionarios.Add(funcionario1);
listaFuncionarios.Add(funcionario2);

var supermercado = new Supermercado("Codeteck Atacarejo", "123465798", "36982147");
supermercado.SetFuncionarios(listaFuncionarios);

Cliente clientePadrao = new Cliente("123456789", "Jarvan IV", "1");
Cliente clienteVip = new ClienteVip("987564321", "Gragas", "2");
Cliente clienteFuncionario = new ClienteFuncionario(funcionario1);

listaClientes.Add(clientePadrao);
listaClientes.Add(clienteVip);
listaClientes.Add(clienteFuncionario);

var produto1 = new Produto("Maçã", 2.33);
var produto2 = new Produto("Pera", 3.56);
List<Produto> listaProdutos = new List<Produto>() { produto1, produto2 };

var fornecedor1 = new Fornecedor("LinkPark Camarões", "123456789");
var fornecedor2 = new Fornecedor("Carrapeta para Caminhões SA", "3698487502");
fornecedor1.SetProdutos(listaProdutos);

listaFornecedores.Add(fornecedor1);
listaFornecedores.Add(fornecedor2);

var formaPagamento = new FormaPagamento();

supermercado.SetFornecedores(listaFornecedores);

while (true) // case pro usuário escolher o que quer fazer
{
    Console.Clear();
    Console.WriteLine("===== MENU SUPERMERCADO =====");
    Console.WriteLine("1 - Listar Funcionários");
    Console.WriteLine("2 - Listar Fornecedores");
    Console.WriteLine("3 - Listar Clientes");
    Console.WriteLine("4 - Realizar Venda");
    Console.WriteLine("5 - Gerenciar Clientes");
    Console.WriteLine("6 - Gerenciar Fornecedores");
    Console.WriteLine("7 - Gerenciar Produtos de Fornecedor");
    Console.WriteLine("8 - Mostrar Dados do Supermercado");
    Console.WriteLine("9 - Sair");
    Console.Write("Escolha uma opção: ");

    var opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            supermercado.GetFuncionarios();
            break;
        case "2":
            supermercado.GetFornecedores();
            break;
        case "3":
            foreach (var c in listaClientes) // faz um loop pra mostrar todos os clientes
            {
                c.GetCliente();
                Console.WriteLine();
            }
            break;
        case "4":
            Console.WriteLine("Escolha o cliente:");
            for (int i = 0; i < listaClientes.Count; i++)
            {
                Console.WriteLine($"{i} - {listaClientes[i].Nome}");
            }
            if (!int.TryParse(Console.ReadLine(), out int clienteIndex) || clienteIndex < 0 || clienteIndex >= listaClientes.Count) // !int.tryparse converte o valor escrito para int 32bit
                break; // se digitar errado , sai do case

            List<Produto> produtosSelecionados = new();
            Console.WriteLine("Escolha os produtos (digite -1 para encerrar):");
            var todosProdutos = listaFornecedores.SelectMany(f => f.Produtos ?? new()).ToList(); // pega todos os produtos de todos os fornecedores, ai na lambda se o produto tiver vazio, ele retorna uma lista vazia
            for (int i = 0; i < todosProdutos.Count; i++)                 //?? = operador nulo-coalescente 
                Console.WriteLine($"{i} - {todosProdutos[i].Nome} - R${todosProdutos[i].Preco}");// for para mostrar todos os produtos

            while (true) // selecionar os produtos
            {
                // esse !int quer dizer que vai converter = true ent !true = false ai vai sair do loop
                if (!int.TryParse(Console.ReadLine(), out int prodIndex) || prodIndex == -1) // out int quer dizer que a var proIndex vai ser criada ali mesmo e receber o valor de que tu digitou
                    break;
                if (prodIndex >= 0 && prodIndex < todosProdutos.Count) 
                    produtosSelecionados.Add(todosProdutos[prodIndex]);
            }
            while (true)
            {
                Console.WriteLine("Indique a forma de pagamento: ");
                Console.WriteLine("0 - credito" +
                    "1 - debito" +
                    "2 - cedulas");
                formaPagamento = Console.ReadLine() switch
                {
                    "0" => FormaPagamento.Credito,
                    "1" => FormaPagamento.Debito,
                    "2" => FormaPagamento.Cedulas,
                };
                break;
            }

            var venda = new Venda(listaClientes[clienteIndex], produtosSelecionados); // cria venda com pra meter no pagamenot
            var pagamento = new Pagamento(venda, formaPagamento); // pagamento
            pagamento.GerarNota();
            break;
        case "9": // sai
            return;
        case "5":
            supermercado.GerenciarClientes(listaClientes); // via pra classe la em baixo
            break;
        case "6":
            supermercado.GerenciarFornecedores(listaFornecedores);// vai pra classe la em baixo
            break;
        case "7":
            supermercado.GerenciarProdutos(listaFornecedores);// vai pra classe la em baixo
            break;
        case "8":
            supermercado.GetDados();
            break;
        default:
            Console.WriteLine("Opção inválida."); // digita certo burro!!!
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar..."); // its over boy
    Console.ReadKey();
}