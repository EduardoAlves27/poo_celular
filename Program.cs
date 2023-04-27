using AulaPOO_Celular;

BibliotecaCelular celular = new BibliotecaCelular();

Console.Clear();
Console.WriteLine("Bem-vindo ao celular!");
Console.WriteLine("----------------------");

while (celular.loop)
{
    Console.WriteLine("Digite 1 para ligar o celular");
    Console.WriteLine("Digite 2 para desligar o celular");
    Console.WriteLine("Digite 3 para sair do programa");

    Console.Write("> ");
    string escolha = Console.ReadLine();



    switch (escolha)
    {
        case "1":
            celular.Ligar();
            break;
        case "2":
            celular.Desligar();
            break;
        case "3":
            Console.WriteLine("Obrigado por utilizar o celular. Até mais!");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    if (celular.ligado)
    {

        Console.Clear();
        Console.WriteLine("Bem-vindo ao programa do celular!");
        Console.WriteLine("----------------------------------");

        Console.Write("Digite a cor do celular: ");
        string cor = Console.ReadLine();

        Console.Write("Digite o modelo do celular: ");
        string modelo = Console.ReadLine();
        Console.Clear();
        um:
        dois:
        Console.WriteLine("----------------------");
        Console.WriteLine("Digite 1 para fazer uma ligação");
        Console.WriteLine("Digite 2 para enviar uma mensagem");
        Console.WriteLine("Digite 3 para voltar ao menu anterior");
        Console.Write("> ");
        string opcao = Console.ReadLine();
        Console.Clear();


        switch (opcao)
        {
            case "1":
                Console.Write("Digite o número para fazer a ligação: ");
                string numeroLigacao = Console.ReadLine();
                celular.FazerLigacao(numeroLigacao);
                Console.Clear();
                goto um;
                break;
            case "2":
                Console.Write("Digite o número para enviar a mensagem: ");
                string numeroMensagem = Console.ReadLine();

                Console.Write("Digite a mensagem: ");
                string mensagem = Console.ReadLine();

                celular.EnviarMensagem(numeroMensagem, mensagem);
                Thread.Sleep(3000);
                Console.Clear();
                goto dois;
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}

