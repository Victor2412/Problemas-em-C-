
Console.WriteLine("1 - Valores numéricos inteiros ímpares situados na faixa de 0 a 40 :");

for (int i = 1; i <= 40; i += 2)
{

    Console.WriteLine(i);

}

Console.WriteLine("Fim");


Console.WriteLine("---------------");


Console.WriteLine("2 - Apresentar o total da soma dos 100 primeiros números inteiros :");

int n = 100;

int soma = 0;


for (int i = 1; i <= n; i++)
{
    soma += i;
}


Console.WriteLine($"A soma dos 100 primeiros números inteiros é: {soma}");


Console.WriteLine("---------------");



Console.WriteLine("3 - Apresentar todos os números divisíveis por 4 que sejam menores que 40 :");

for (int i = 1; i < 40; i++)
{
    if (i % 4 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("---------------");

Console.WriteLine("4 - Apresentar os quadrados dos números inteiros de 15 a 200 : ");

for (int i = 15; i <= 200; i++)
{
    int quadrado = i * i;

    Console.WriteLine($"O quadrado de {i} e {quadrado}");
}


Console.WriteLine("---------------");



Console.WriteLine("5 - Apresentar o resultado da soma de todos os valores pares existentes na faixa numérica de 1 a 50 : ");

int somaTotal = 0;

for (int i = 1; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        somaTotal += i;
    }

}
Console.WriteLine("A soma dos valores pares de 1 a 50 é: " + somaTotal);