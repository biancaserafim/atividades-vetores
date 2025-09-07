using System;
using System.Text;

class atv05
{
    static void Main()
    {
        string? msg = Console.ReadLine();

        if (string.IsNullOrEmpty(msg))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        StringBuilder saida = new StringBuilder();

        for (int i = 0; i < msg.Length; i++)
        {
            if (msg[i] == 'p' && i + 1 < msg.Length && Char.IsLetter(msg[i + 1]))
            {
                saida.Append(msg[i + 1]);
                i++;
            }
            else
            {
                saida.Append(msg[i]);
            }
        }

        Console.WriteLine(saida.ToString());
    }
}
