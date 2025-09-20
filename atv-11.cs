using System;

class atv11
{
    static void Main()
    {
        string codificada = Console.ReadLine()!;
        string decodificada = "";

        int i = 0;
        while (i < codificada.Length)
        {
            if (codificada[i] == ' ')
            {
                decodificada += ' ';
                i++;
            }
            else if (codificada[i] == 'p' && i + 1 < codificada.Length)
            {
                decodificada += codificada[i + 1];
                i += 2;
            }
            else
            {
                i++;
            }
        }

        Console.WriteLine(decodificada);
    }
}