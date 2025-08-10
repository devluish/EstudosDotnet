// Primeiro exercicio
// 1- Criar estrutura de tabelas
// 2- Criar estrutura de menu
// 3- Capturar resposta do usuário
// 4- Criar a cada função dentro dos cases

void PrimeiraMensagem()
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("     SEJA BEM-VINDO    ");
    Console.WriteLine("          MENU         ");
    Console.WriteLine("-----------------------");
}

void Menu()
{
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
            Console.WriteLine("Você escolheu a opção: " + escolha);
            break;

        case 2: 
            Console.WriteLine("Você escolheu a opção: " + escolha);
            break;
            
        case 3:
            Console.WriteLine("Você escolheu a opção: " + escolha);
            break;

        case 4:
            Console.WriteLine("Saindo do programa");
            break;

    }
    

}


PrimeiraMensagem();
Menu();