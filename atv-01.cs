using System;
using MinhaBiblioteca;


class atv01
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine()!);

        int[] meuVetor = new int[n];
        Biblioteca.lerVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        int soma = Biblioteca.somarVetor(meuVetor);
        Console.WriteLine($"\nSoma dos elementos do vetor: {soma}");

    }
}