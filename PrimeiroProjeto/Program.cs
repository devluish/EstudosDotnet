// Screen Sound

// Variáveis, parâmetros e campos privados -> Usar camelCase
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

// Métodos(incluindo void), propriedades e classes -> Usar PascalCase
// Todas começam com letra maiúscula
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("************************");
}
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n1- Para registrar uma banda");
    Console.WriteLine("2- Para mostrar todas as bandas");
    Console.WriteLine("3- Para avaliar uma banda");
    Console.WriteLine("4- Para exibir a média das bandas");
    Console.WriteLine("5- Sair");
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();



