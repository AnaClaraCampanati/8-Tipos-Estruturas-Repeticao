// Faça um programa em C# que imprima a soma dos números de 1 até 1000.

int soma = 0;

for (int i = 1; i <= 1000; i++)
{
    soma = soma + i;
}

Console.WriteLine("A soma dos números é: " + soma);