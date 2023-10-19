Console.WriteLine("## Instrução while ##\n");

while (true)
{
    Console.WriteLine("\nInforme um número inteiro: (para sair digite 999)");

    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 999)
    {
        break;
    }
    if (numero % 2 == 0)
    {
        Console.WriteLine($"{numero} é par");
    }
    else
    {
        Console.WriteLine($"{numero} é impar");
    }
}

Console.WriteLine("Fim de processamento");
Console.ReadLine();