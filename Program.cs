Console.Clear();
Console.WriteLine("====================================");
Console.WriteLine("Bem vindo ao projeto CALCULADORA!");
Console.WriteLine("====================================");

Soma();

static void Soma()
{
    Console.WriteLine("Digite o PRIMEIRO valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o SEGUNDO valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
}