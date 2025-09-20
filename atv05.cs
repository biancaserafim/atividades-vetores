using System;

class atv05
{
    static void Main()
    {
        int n;
        Console.WriteLine("Informe o tamanho da fita de DNA (até 50):");
        n = int.Parse(Console.ReadLine()!);

        char[] dna = new char[n];
        char[] complemento = new char[n];

        Console.WriteLine("Digite as bases do DNA (A, T, C, G):");
        for (int i = 0; i < n; i++)
        {
            dna[i] = char.ToUpper(Console.ReadLine()![0]);
        }

        for (int i = 0; i < n; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complemento[i] = 'T';
                    break;
                case 'T':
                    complemento[i] = 'A';
                    break;
                case 'C':
                    complemento[i] = 'G';
                    break;
                case 'G':
                    complemento[i] = 'C';
                    break;
                default:
                    complemento[i] = '?';
                    break;
            }
        }

        Console.WriteLine("Vetor DNA original:");
        for (int i = 0; i < n; i++)
            Console.Write(dna[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Vetor DNA complementar:");
        for (int i = 0; i < n; i++)
            Console.Write(complemento[i] + " ");
        Console.WriteLine();
    }
}