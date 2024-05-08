Console.Clear();
Console.WriteLine("====================================");
Console.WriteLine("Bem vindo ao projeto CALCULADORA!");
Console.WriteLine("====================================");

Operacao();

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
}

static void Operacao()
{
    Console.WriteLine("Escolha o tipo de operação que deseja realizar:");
    string tipoOperacao = Console.ReadLine();

    switch (tipoOperacao)
    {
        case "+":
            Soma();
            break;
        case "-":
            Subtracao();
            break;
        case "*":
            Multiplicacao();
            break;
        case "/":
            Divisao();
            break;
        default:
            Console.WriteLine($"Operação inválida");
            break;
    }
}