using System;

class Program
{
    static void Main()
    {
        double[] notas = new double[5];
        Console.WriteLine("Digite as 5 notas:");


        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

    
        double maior = notas[0];
        double menor = notas[0];

       
        for (int i = 1; i < 5; i++)
        {
            if (notas[i] > maior)
                maior = notas[i];
            if (notas[i] < menor)
                menor = notas[i];
        }

    
        double soma = 0;
        for (int i = 0; i < 5; i++)
            soma += notas[i];

     
        soma -= maior + menor;

        double media = soma / 3;

        Console.WriteLine($"\nMaior nota: {maior:F1}");
        Console.WriteLine($"Menor nota: {menor:F1}");
        Console.WriteLine($"Média das notas restantes: {media:F1}");
    }
}
