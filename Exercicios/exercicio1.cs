// Primeiro exercicio
// 1- Criar estrutura de tabelas
// 2- Criar estrutura de menu
// 3- Capturar resposta do usuário
// 4- Criar a cada função dentro dos cases

List<string> dadosUsuarioNome = new List<string>();
List<int> dadosUsuarioIdade = new List<int>();

void PrimeiraMensagem()
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("     SEJA BEM-VINDO    ");
    Console.WriteLine("          MENU         ");
    Console.WriteLine("-----------------------");
}

void Menu()
{
    Console.Clear();
    PrimeiraMensagem();

    Console.WriteLine("\n1- Para cadastrar");
    Console.WriteLine("2- Para verificar cadastro");
    Console.WriteLine("3- Para excluir cadastro");
    Console.WriteLine("4- Sair do programa");

    // Capturando escolha do usuário
    Console.Write("\nDigite sua opção: ");
    string escolha = Console.ReadLine()!;
    int escolhaIntUsuario = int.Parse(escolha);

    switch(escolhaIntUsuario)
    {
        case 1:
            CadastrarUsuario();
            break;

        case 2: 
            ExibirCadastro();
            break;
            
        case 3:
            Console.WriteLine("Você escolheu a opção: " + escolha);
            break;

        case 4:
            Console.WriteLine("Saindo do programa");
            break;

    }  
}

// Método para cadastrar usuário
void CadastrarUsuario()
{
    Console.Clear();
    Console.WriteLine("Cadastro de usuário");
    
    Console.Write("Nome: ");
    string nomeUsuario = Console.ReadLine()!;
    Console.WriteLine($"Nome cadastrado com sucesso: {nomeUsuario}");
    dadosUsuarioNome.Add(nomeUsuario);

    Console.Write("Idade: ");
    string idadeUsuario = Console.ReadLine()!;
    Console.WriteLine($"Idade cadastrada com sucesso: {idadeUsuario}");
    int idadeNumero = int.Parse(idadeUsuario);
    dadosUsuarioIdade.Add(idadeNumero);
    Menu();
}

void ExibirCadastro()
{
    Console.Clear();
    Console.WriteLine("Exibir cadastro de usuário\n");
    Console.WriteLine("1- Visualizar nome do usuário");
    Console.WriteLine("2- Visualizar idade do usuário");
    Console.WriteLine("\n3- Voltar ao menu principal");

    int escolheUsuario = int.Parse(Console.ReadLine()!);

    switch (escolheUsuario)
    {
        case 1:
            for (int i = 0; i < dadosUsuarioNome.Count; i++)
            {
                Console.Clear();
                Console.Write($"\nNome cadastrado: {dadosUsuarioNome[i]}");
            }
            Console.WriteLine("\nDigite qualquer tecla para voltar");
            Console.ReadKey();
            ExibirCadastro();
            break;

        case 2:
            for (int i = 0; i < dadosUsuarioIdade.Count; i++)
            {
                Console.Clear();
                Console.Write($"Idade cadastrada: {dadosUsuarioIdade[i]}");
            }
            Console.WriteLine("\nDigite qualquer tecla para voltar");
            Console.ReadKey();
            ExibirCadastro();
            break;

        case 3:
            Menu();
            break;
    }
}

Menu();