using System;
using MinhaBiblioteca;

class atv04
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        int maiorElemento = Biblioteca.encontrarMaiorElemento(meuVetor);
        Console.WriteLine($"\nMaior elemento do vetor: {maiorElemento}");
    }
}