Console.WriteLine("## Instrução while ##\n");

var i = 10;
while (i > 0)
{
Console.WriteLine($"i = {i}");
i--;
}

Console.WriteLine("\n----------------------\n");

int numero;
int contador = 1;

Console.WriteLine("Digite um número maior que zero");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    //loop while
    Console.WriteLine($"\n## Tabuada do {numero}");
    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero!");
}

Console.WriteLine("\n------------------\n");

while (true)
{
    Console.WriteLine("\nInforme um número inteiro: (para sair digite 999)");

    int numeroLoop = Convert.ToInt32(Console.ReadLine());

    if (numeroLoop == 999)
    {
        break;
    }
    if (numeroLoop % 2 == 0)
    {
        Console.WriteLine($"{numeroLoop} é par");
    }
    else
    {
        Console.WriteLine($"{numeroLoop} é impar");
    }
}

Console.WriteLine("\n------------------\n");

int x = 0;
while (x<5)
{
    int y = 0;
	while (y<5)
	{
        Console.Write($"({x},{y})");
        y++;
    }
    x++; 
    Console.WriteLine();
}


Console.WriteLine("Fim de processamento");
Console.ReadLine();