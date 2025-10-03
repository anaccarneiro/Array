using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] notas = new int[60];
            int nota = 0;


            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota do aluno {i + 1} (ou um valor negativo para sair):");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0)
                {
                    break;
                }

                notas[i] = nota;
            }

            Console.WriteLine("Notas dos alunos:");
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 0)
                {
                    Console.WriteLine($"Aluno {i + 1}: {notas[i]}");
                }
            }
        }
    }
}
