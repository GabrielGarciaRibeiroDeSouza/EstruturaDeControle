Console.WriteLine("## Estrutura de repetição com goto/label ##\n");

int i = 1;

//não é recomendado o uso desse modelo de loop, é muito antigo
repetir:

Console.WriteLine($"i= {i}");

i++;

if (i <= 10)
{
    goto repetir;
}

Console.WriteLine("Fim de processamento...");

Console.ReadLine();