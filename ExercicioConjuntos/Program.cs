using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos alunos possui o Curso A: ");
            int aux = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            HashSet<int> A = new HashSet<int>();
            for (int i = 0; i < aux; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o Curso B: ");
            aux = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            HashSet<int> B = new HashSet<int>();
            for (int i = 0; i < aux; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o Curso C: ");
            aux = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            HashSet<int> C = new HashSet<int>();
            for (int i = 0; i < aux; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }
            B.UnionWith(A);
            C.UnionWith(B);
            Console.WriteLine("Total de Alunos: " + C.Count);
        }
    }
}
