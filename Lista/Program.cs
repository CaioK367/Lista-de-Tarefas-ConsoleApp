using Lista;

Tarefa t = new Tarefa();

static void Menu()
{
    Console.WriteLine("Olá! Seja bem vindo a lista de tarefas");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Remover tarefa");
    Console.WriteLine("3 - Listar tarefas");
    Console.WriteLine("4 - Sair");
}

bool continuar = true;
while (continuar) {
    Menu();

    switch (Console.ReadLine())
    {
        case "1":
            t.AdicionarTarefa();
            break;
        case "2":
            t.RemoverTarefa();
            break;
        case "3":
            t.Exibir();
            break;
        case "4":
            continuar = false;
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}










