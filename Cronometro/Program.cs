// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao cronômetro.");

//Start(6);
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("s = segundos => 10s = 10 segundos");
    Console.WriteLine("m = minutos => 1m = 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower(); //tolower para desconsiderar maiusc e minusc
    char tipo = char.Parse(data.Substring(data.Length-1,1)); //data length - 1 pega o último caracter digitado
    int tempo = int.Parse(data.Substring(0,data.Length-1));
    int multiplicador = 1;

    if (tipo == 'm')
    {
        multiplicador=60;
    }
    if (tempo == 0)
    {
        System.Environment.Exit(0);
    }

    PreStart(tempo*multiplicador);

    // Console.WriteLine(data);
    // Console.WriteLine(tipo);
    // Console.WriteLine(tempo);

}

static void PreStart(int tempo)
    {
        Console.Clear();
        Console.WriteLine("Preparando...");
        Thread.Sleep(1000);
        Console.WriteLine("Iniciando...");
        Thread.Sleep(2000);
        Start(tempo);

    }

static void Start(int time) {
    //int time = 10;
    int tempoAtual = 0;

    while(tempoAtual!=time) {
        Console.Clear();
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);    
        }

        Console.Clear();
        Console.WriteLine("Cronômetro finalizado.");
        Thread.Sleep(2500);
        Menu();
}
