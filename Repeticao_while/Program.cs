﻿Console.WriteLine("## Instrução while ##\n");

var i =  10;
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

if (numero >0)
{
    //loop while
    Console.WriteLine($"\n## Tabuada do {numero}");
    while (contador <11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero*contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero!");
}
Console.WriteLine("Fim de processamento");
Console.ReadLine();