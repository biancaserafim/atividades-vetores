using System;
using MinhaBiblioteca;

class atv06
{
    static void Main()
    {
        int n;
        Console.WriteLine("Informe o tamanho do vetor:");
        n = int.Parse(Console.ReadLine()!);

        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        Console.WriteLine();

        Console.WriteLine("Digite um número para procurar no vetor:");
        int valor = int.Parse(Console.ReadLine()!);

        bool encontrado = false;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                Console.WriteLine($"Valor encontrado na posição {i}");
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
            Console.WriteLine("Valor não encontrado no vetor.");
    }
}