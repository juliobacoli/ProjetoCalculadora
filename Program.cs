Console.Clear();
Console.WriteLine("====================================");
Console.WriteLine("Bem vindo ao projeto CALCULADORA!");
Console.WriteLine("====================================\n");

Menu();

static void Soma()
{
    Console.Clear();

    Console.WriteLine($"Operação -> {nameof(Soma)}");
    Console.WriteLine("Digite o PRIMEIRO valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o SEGUNDO valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine($"Operação -> {nameof(Subtracao)}");
    Console.WriteLine("Digite o PRIMEIRO valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o SEGUNDO valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é {valor1 - valor2}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine($"Operação -> {nameof(Multiplicacao)}");
    Console.WriteLine("Digite o PRIMEIRO valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o SEGUNDO valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é {valor1 * valor2}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine($"Operação -> {nameof(Divisao)}");
    Console.WriteLine("Digite o PRIMEIRO valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o SEGUNDO valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é {valor1 / valor2}");
    Console.ReadKey();
    Menu();
}

static void SeletorOperacao()
{
    Console.WriteLine("Escolha o tipo de operação que deseja realizar:");
    int tipoOperacao = int.Parse(Console.ReadLine());

    switch (tipoOperacao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        default:
            Menu();
            break;
    }
}

static void Menu()
{
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao");

    Console.Write("\n");

    SeletorOperacao();

}