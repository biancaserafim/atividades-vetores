using System;
using MinhaBiblioteca;

class atv07
{
    static void Main()
    {
        int n;
        Console.WriteLine("Informe o tamanho dos vetores:");
        n = int.Parse(Console.ReadLine()!);

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];
        int[] resultado = new int[n];

        Console.WriteLine("Preencha o primeiro vetor:");
        Biblioteca.lerVetor(vetor1);

        Console.WriteLine("Preencha o segundo vetor:");
        Biblioteca.lerVetor(vetor2);

        for (int i = 0; i < n; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        Console.WriteLine("Vetor resultante da multiplicação:");
        Biblioteca.mostrarVetor(resultado);
        Console.WriteLine();
    }
}