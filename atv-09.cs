using System;

class atv09
{
    static void Main()
    {
        Console.WriteLine("Informe o tamanho do vetor de caracteres:");
        int n = int.Parse(Console.ReadLine()!);

        char[] vetor = new char[n];

        Console.WriteLine("Digite os caracteres:");
        for (int i = 0; i < n; i++)
        {
            vetor[i] = Console.ReadLine()![0];
        }

        Console.WriteLine("Vetor invertido:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}