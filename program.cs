// Screen Sound

// List<string> Bandas = new List<string> { "The Beatles", "ACDC" }; // Criando uma nova lista de bandas do tipo string

Dictionary<string, List<int>> Bandas = new Dictionary<string, List<int>>();
Bandas.Add("Link Park", new List<int> { 10, 8, 6 });
Bandas.Add("The Beatles", new List<int> ());


void ExibirMensagem () 
{
    Console.WriteLine(@"

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    
}

void ExibirOpcoesMenu ()
{

    ExibirMensagem();
    Console.WriteLine("\n1 - Registrar banda");
    Console.WriteLine("2 - Listar bandas cadastradas");
    Console.WriteLine("3 - Avaliar uma banda cadastrada");
    Console.WriteLine("4 - Exibir média de uma banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\n Digite a opção desejada: ");
    string opcao = Console.ReadLine()!; // Estamos definindo se o valor digitado não foi nulo.

    int opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            CalculaMedia();
            break;
        case 0:
            Console.WriteLine("Até logo :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
   
}



void RegistrarBandas()
{
    Console.Clear();
    ExibirTitulo("Registro de Bandas: ");
    Console.Write("Qual o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Bandas.Add(nomeBanda,new List<int>());
    Console.WriteLine($"\nA Banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();

};


void ListarBandas()
{
    Console.Clear();
    ExibirTitulo("Listagem de Bandas: ");

    //for(int i = 0; i < Bandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {Bandas[i]}");
    //}
    foreach (string banda in Bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}



void ExibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}



void AvaliarBanda()
{
    // Digite qual banda deseja avaliar
    // Se a banda existir no dicionário atribuir nota.
    // senão retorna ao menu principal.
    Console.Clear();
    ExibirTitulo("Avaliação de Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();
    if (Bandas.ContainsKey(nomeDaBanda)){
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        Bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nA banda: {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}



void CalculaMedia() 
{
    Console.Clear();
    ExibirTitulo("Calculo de média: ");
    Console.Write("Qual banda deseja calcular a média: ");
    string nomeBanda = Console.ReadLine()!;
    if(Bandas.ContainsKey(nomeBanda))
    {
        List<int> notasBanda = Bandas[nomeBanda];
        Console.WriteLine($"A média da banda: {nomeBanda} é {notasBanda.Average()}.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nA banda: {nomeBanda} não foi encontrada.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    }
}

ExibirOpcoesMenu();
