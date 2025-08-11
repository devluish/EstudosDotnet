// Screen Sound

// Variáveis, parâmetros e campos privados -> Usar camelCase
string mensagemDeBoasVindas = "      SCREEN SOUND";

// Métodos(incluindo void), propriedades e classes -> Usar PascalCase
// Todas começam com letra maiúscula
void ExibirLogo()
{
    Console.WriteLine("************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("************************");
}

// Foi criado uma lista para armazenar os dados de cadastro do usuário.
// Criação da lista por padrão vem com o nome de Strings -> Fazer a alteração pelo nome da lista
List<string> listaDeBandas = new List<string> {"Pink Floyd","Iron Maiden", "Oficina G3", "Deep Purple"};


void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("Menu");
    Console.WriteLine("\n1- Para registrar uma banda");
    Console.WriteLine("2- Para mostrar todas as bandas");
    Console.WriteLine("3- Para avaliar uma banda");
    Console.WriteLine("4- Para exibir a média das bandas");
    Console.WriteLine("5- Sair");

    // Usado o apenas o Write pois não quer que pule linha e sim o Readline ficar na mesma linha do ultimo console.
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
            break;
        case 5:
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("REGISTRO DE BANDA\n");
    Console.Write("Nome: ");
    string nomeBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeBanda); // Adicionando a lista de bandas.
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("EXIBINDO TODAS AS BANDAS REGISTRADAS\n");

    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDeBandas[i]}");
    }


    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();


