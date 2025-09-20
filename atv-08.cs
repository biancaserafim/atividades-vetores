using System;
using MinhaBiblioteca;

class atv08
{
    static void Main()
    {
        int n;
        Console.WriteLine("Informe o tamanho do vetor:");
        n = int.Parse(Console.ReadLine()!);

        int[] vetor = new int[n];
        Biblioteca.lerVetor(vetor);

        Console.WriteLine("Informe o valor a ser contado:");
        int valor = int.Parse(Console.ReadLine()!);

        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
                contador++;
        }

        Console.WriteLine($"O valor {valor} aparece {contador} vezes no vetor.");
    }
}