using System;

class ExercicioDNA
{
    static string complementarDNA(string dna)
    {
        int n = dna.Length;
        dna = dna.ToUpper();      
          char[] complemento = new char[n];
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

                default: complemento[i] = 'N';
                    break;


                }


        }

        return new string(complemento);

    }

    static void Main()
    {
        string dna, comp;
        Console.WriteLine("Entre com a fita do DNA :");
        dna = Console.ReadLine();
        comp = complementarDNA(dna);
        Console.WriteLine("Fita complementar :" + complementarDNA(dna));
}
}