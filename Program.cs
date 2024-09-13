using System;

namespace ExercDoProf_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtde;

            Console.Write("A quantidade de nomes que deseja inserir: ");
            qtde = int.Parse(Console.ReadLine());

            string[] nomes = new string[qtde];
            int[] idade = new int[qtde];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"\nDigite o nome {i + 1}/{qtde}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite idade desta pessoa: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("-=-=-=-=-=-= Lista de Nomes =-=-=-=-=-");
            Console.WriteLine("");

            int j = 0;

            foreach (string i in nomes)
            {
                Console.WriteLine($"{i}, {idade[j]} anos de idade.");
                j++;
            }

            Console.WriteLine("");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("");
        }
    }
}
