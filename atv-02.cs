using System;
using MinhaBiblioteca;

class atv02
{
    static void Main()
    
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        int quantidadeImpares = Biblioteca.contarImpares(meuVetor);
        Console.WriteLine($"\nQuantidade de valores ímpares no vetor: {quantidadeImpares}");

    }
}