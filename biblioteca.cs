using System;
using System.Collections.Specialized;

namespace MinhaBiblioteca
{
    public class Biblioteca
    {
        public static void lerVetor(int[] vetor)
        {
            Console.WriteLine("Entre com os dados do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Array[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }// fim for

        }

        public static void gerarVetor(int[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 100);

        }
        public static void mostrarVetor(int[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write("|" + vetor[i]);

        }

        static void Main()
        {
            int n;
            Console.WriteLine("Entre com o tamanho do vetor:");
            n = int.Parse(Console.ReadLine());
            int[] meuVetor = new int[n];
            lerVetor(meuVetor);
            mostrarVetor(meuVetor);

        }
        public static int somarVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }

        public static int contarImpares(int[] vetor)
        {
            int contador = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                    contador++;
            }
            return contador;
        }

        public static int encontrarMenorElemento(int[] vetor)
        {
            int menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];
            }
            return menor;
        }
        public static int encontrarMaiorElemento(int[] vetor)
        {
            int maior = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                    maior = vetor[i];
            }
            return maior;
        }
        public static string complementarDNA(string dna)
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
                    default:
                        complemento[i] = 'N';
                        break;
                }
            }
            return new string(complemento);
        }

        public static void sortearVetor(int[] vetor)
        {
            Random rand = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(1, 100);
            }
        }

        public static int procurarNumero(int[] vetor, int num)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }

        
    }
}