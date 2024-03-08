// See https://aka.ms/new-console-template for more information

Console.WriteLine("Calculadora");

// Multiplicacao();
// Soma();
// Subtracao();
// Divisao();

Menu();

static void Soma() {
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;
    // Console.WriteLine("O resultado da soma de "+valor1+ " e "+valor2+" é igual a "+resultado);
    Console.WriteLine($"O resultado da soma de {valor1} e {valor2} é igual a {resultado}");
}

static void Subtracao() {
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 - valor2;
    Console.WriteLine($"O resultado da subtração de {valor1} e {valor2} é igual a {resultado}");
}

static void Divisao() {
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 / valor2;
    Console.WriteLine($"O resultado da divisão de {valor1} por {valor2} é igual a {resultado}");
}

static void Multiplicacao() {
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 * valor2;
    Console.WriteLine($"O resultado da multiplicação de {valor1} e {valor2} é igual a {resultado}");
}

static void Menu() {
    Console.Clear();
    Console.WriteLine("Que operação deseja realizar?");
    Console.WriteLine("1.- Soma");
    Console.WriteLine("2.- Subtração");
    Console.WriteLine("3.- Multiplicação");
    Console.WriteLine("4.- Divisão");
    Console.WriteLine("5.- Sair do Sistema");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Selecione uma opção: ");

    short operacao = short.Parse(Console.ReadLine());

    switch(operacao){
        case 1: Soma();
        break;
        case 2: Subtracao();
        break;
        case 3: Multiplicacao();
        break;
        case 4: Divisao();
        break;
        case 5: System.Enviroment.Exit(0);
        break;
        default: Menu();
        break;
    }
}