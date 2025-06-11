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
    public List<Funcionario> Funcionarios { get; set; }


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
        if (Funcionarios is null || Funcionarios.Count == 0) // se não tiver feito o set antes vai cair nesse if
        {
            Console.WriteLine("NENHUM FUNCIONARIO CADASTRADO...");
            return;
        }
        foreach (Funcionario funcionario in this.Funcionarios)
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

    public void GerenciarClientes(List<Cliente> clientes)
    {
        Console.WriteLine("1 - Adicionar Cliente\n2 - Atualizar Cliente\n3 - Remover Cliente");
        var opc = Console.ReadLine();
        switch (opc)
        {
            case "1": // cria variavel e popula
                Console.Write("Nome: "); var nome = Console.ReadLine();
                Console.Write("CPF: "); var cpf = Console.ReadLine();
                Console.Write("ID: "); var id = Console.ReadLine();
                clientes.Add(new Cliente(cpf, nome, id));
                break;

            case "2": // pega o index que tu colocou e atualiza o nome e cpf
                for (int i = 0; i < clientes.Count; i++) Console.WriteLine($"{i} - {clientes[i].Nome}");
                if (!int.TryParse(Console.ReadLine(), out int idx) || idx >= clientes.Count) return;
                Console.Write("Novo Nome: "); clientes[idx].Nome = Console.ReadLine();
                Console.Write("Novo CPF: "); clientes[idx].Cpf = Console.ReadLine();
                break;

            case "3": // pega o index que tu colocou e remove o cliente
                for (int i = 0; i < clientes.Count; i++) Console.WriteLine($"{i} - {clientes[i].Nome}");
                if (!int.TryParse(Console.ReadLine(), out int index) || index >= clientes.Count) return;
                clientes.RemoveAt(index);
                break;
        }
    }
    public void GerenciarFornecedores(List<Fornecedor> fornecedores) // mesma dinamica dos clientes
    {
        Console.WriteLine("1 - Adicionar Fornecedor\n2 - Atualizar Fornecedor\n3 - Remover Fornecedor");
        var opc = Console.ReadLine();
        switch (opc)
        {
            case "1":
                Console.Write("Nome: "); var nome = Console.ReadLine();
                Console.Write("CNPJ: "); var cnpj = Console.ReadLine();
                fornecedores.Add(new Fornecedor(nome, cnpj));
                break;
            case "2":
                for (int i = 0; i < fornecedores.Count; i++) Console.WriteLine($"{i} - {fornecedores[i].Nome}");
                if (!int.TryParse(Console.ReadLine(), out int idx) || idx >= fornecedores.Count) return;
                Console.Write("Novo Nome: "); fornecedores[idx].Nome = Console.ReadLine();
                Console.Write("Novo CNPJ: "); fornecedores[idx].Cnpj = Console.ReadLine();
                break;
            case "3":
                for (int i = 0; i < fornecedores.Count; i++) Console.WriteLine($"{i} - {fornecedores[i].Nome}");
                if (!int.TryParse(Console.ReadLine(), out int index) || index >= fornecedores.Count) return;
                fornecedores.RemoveAt(index);
                break;
        }
    }
    public void GerenciarProdutos(List<Fornecedor> fornecedores)
    {
        Console.WriteLine("Escolha o fornecedor para gerenciar produtos:");
        for (int i = 0; i < fornecedores.Count; i++)
            Console.WriteLine($"{i} - {fornecedores[i].Nome}");
        if (!int.TryParse(Console.ReadLine(), out int fIndex) || fIndex >= fornecedores.Count) return;
        var fornecedor = fornecedores[fIndex];
        if (fornecedor.Produtos == null)
            fornecedor.Produtos = new List<Produto>();

        Console.WriteLine("1 - Adicionar Produto\n2 - Atualizar Produto\n3 - Remover Produto");
        var opc = Console.ReadLine();
        switch (opc)
        {
            case "1":
                Console.Write("Nome: "); var nome = Console.ReadLine();
                Console.Write("Preço: "); double.TryParse(Console.ReadLine(), out double preco);
                fornecedor.Produtos.Add(new Produto(nome, preco));
                break;
            case "2":
                for (int i = 0; i < fornecedor.Produtos.Count; i++)
                    Console.WriteLine($"{i} - {fornecedor.Produtos[i].Nome}");
                if (!int.TryParse(Console.ReadLine(), out int pIdx) || pIdx >= fornecedor.Produtos.Count) return;
                Console.Write("Novo Nome: "); fornecedor.Produtos[pIdx].Nome = Console.ReadLine();
                Console.Write("Novo Preço: "); double.TryParse(Console.ReadLine(), out double novoPreco);
                fornecedor.Produtos[pIdx].Preco = novoPreco;
                break;
            case "3":
                for (int i = 0; i < fornecedor.Produtos.Count; i++)
                    Console.WriteLine($"{i} - {fornecedor.Produtos[i].Nome}");
                if (!int.TryParse(Console.ReadLine(), out int delIdx) || delIdx >= fornecedor.Produtos.Count) return;
                fornecedor.Produtos.RemoveAt(delIdx);
                break;
        }
    }
}
