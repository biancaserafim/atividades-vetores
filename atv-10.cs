using System;

class atv10
{
    static void Main()
    {
        Console.WriteLine("Informe quantas vezes o dado foi lançado:");
        int n = int.Parse(Console.ReadLine()!);

        int[] resultados = new int[n];

        Console.WriteLine("Digite os resultados dos lançamentos:");
        for (int i = 0; i < n; i++)
        {
            resultados[i] = int.Parse(Console.ReadLine()!);
        }

        for (int face = 1; face <= 6; face++)
        {
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (resultados[i] == face)
                    cont++;
            }
            Console.WriteLine($"Face {face}: {cont} ocorrência(s)");
        }
    }
}