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
            Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
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
    Console.WriteLine("REGISTRO DE BANDA");
    Console.Write("Nome: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();

    ExibirOpcoesDoMenu();

}

ExibirOpcoesDoMenu();


