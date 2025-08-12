// Screen Sound
// Todas começam com letra maiúscula




// O que aconteceu aqui? Houve uma mudança do formato List para um Disctionary, qual seria a lógica por trás?
// 1-) Dicionario<Tipo da chave "string", <Definir os valores "int">> Depois colocar o nome do dicionário
// 2-) Completa automaticamente com new Dictionary igual o dicionário criado

// List<string> listaDeBandas = new List<string> {"Pink Floyd","Iron Maiden", "Oficina G3", "Deep Purple"};
Dictionary<string, List<double>> bandasRegistradas = new Dictionary<string, List<double>>();
bandasRegistradas.Add("Link Park", new List<double> { 10, 8, 9 });
bandasRegistradas.Add("Pink Floyd", new List<double>());

string mensagemDeBoasVindas = "      SCREEN SOUND";

void ExibirLogo()
{
    Console.WriteLine("************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("************************");
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

// Foi criado uma lista para armazenar os dados de cadastro do usuário.
// Criação da lista por padrão vem com o nome de Strings -> Fazer a alteração pelo nome da lista


void ExibirOpcoesDoMenu()
{
    Console.Clear();
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
            AvaliarBanda();
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
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Nome: ");
    string nomeBanda = Console.ReadLine()!;
    // listaDeBandas.Add(nomeBanda); // Adicionando a lista de bandas. -> Formato antigo com lista
    bandasRegistradas.Add(nomeBanda, new List<double>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("EXIBINDO TODAS AS BANDAS REGISTRADAS");

    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDeBandas[i]}");
    //}

    //foreach é uma maneira mais simples de percorrer o looping, precisará ser análisado qual das formas optar, entre o foreach ou o for padrão;
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }


    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("AVALIAÇÃO DAS BANDAS");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    } else
    {
        Console.WriteLine($"A Banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();   
    }


    // Digitar banda que deseja avaliar (Pesquisar/Buscar)
    // Se a banda existir no dicionário >> Atribuir uma nota
    // Se não exister exibe uma mensagem e voltar para o menu principal

}

ExibirOpcoesDoMenu();

