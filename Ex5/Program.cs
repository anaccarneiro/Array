using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*05. Escreva um programa que armazene as notas dos alunos que fizeram a prova 1 da disciplina Algoritmos
            e Técnicas de Programação (ATP). Considere que o vetor possa conter até 60 registros. Sabe-se que, no
            dia da prova, alguns alunos podem ter faltado. Com isso, leia as notas até que seja digitado um valor negativo
            ou enquanto a quantidade de alunos for inferior à capacidade do vetor. Imprima:
            ● Notas de todos os alunos
            ● Notas acima da média
            Dica: para implementar esse programa, a estrutura de repetição irá continuar enquanto a quantidade de
            notas for menor ou igual a 60 e não tiver sido informado uma nota negativa. Pense em como implementar
            isso.*/

            int[] notas = new int[6];
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
